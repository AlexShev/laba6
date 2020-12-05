using System;
using System.Collections.Generic;
using System.Linq;

namespace laba6
{
    public class Database
    {
        private readonly SortedDictionary<string, Admin> _admins;

        private readonly SortedDictionary<string, Client> _clients;
       
        private readonly SortedDictionary<string, ClientTonw> _sortedClients;

        public Database()
        {
            _admins = new SortedDictionary<string, Admin> { ["AlexShev"] = new Admin("AlexShev", "0123", true) };

            _clients = new SortedDictionary<string, Client>();

            _sortedClients = new SortedDictionary<string, ClientTonw>();

            AddСlient(new Client("eduard.bystrov", "123", "Быстров Эдуард", "m", "4.11.1990", "Таганрог", "8(951)849-94-01", true));
        }

        private class ClientTonw
        {
            private readonly List<Client> _female = new List<Client>();

            private readonly List<Client> _masculine = new List<Client>();

            public List<Client> ChoesPartTounBySex(Client client, bool oppositeSex = false)
            {
                var isMasculine = client.MySex.MySex == Gender.Sex.masculine;

                return (oppositeSex) ? (isMasculine) ? _female : _masculine : (isMasculine) ? _masculine : _female;
            }
        }

        private List<Client> ChoesToun(Client client, bool oppositeSex = false)
        {
            if (!_sortedClients.ContainsKey(client.MyCity))
            {
                _sortedClients.Add(client.MyCity, new ClientTonw());
            }

            return _sortedClients[client.MyCity].ChoesPartTounBySex(client, oppositeSex);
        }

		public void GenerateCityInDataBase(int size, string city = null)
        {
            using var generateСlient = new GeneratorUserInfoClient();
            {
                for (var i = 0; i < size; i++)
                {
                    try
                    {
                        AddСlient(generateСlient.GenerateСlient(city));
                    }
                    catch (Exception) { }
                }
            }
        }

        public void AddAdmin(Admin admin)
        {
            _admins.Add(admin.Login, admin);
        }

        public void AddСlient(Client client)
        {
            _clients.Add(client.Login, client);

            ChoesToun(client).Add(client);
        }

        public bool IsFreeLoginClients(string login) => !(_clients.ContainsKey(login));

        public bool IsFreeLoginAdmins(string login) => !(_admins.ContainsKey(login));

        public bool IsMyAdmin(Admin admin) => _admins.ContainsValue(admin);

        public bool IsMyClient(string login, string password)
            => _clients.ContainsKey(login) && _clients[login].IsMyPassword(password);

        public Client GetClient(string login, string password)
            => (IsMyClient(login, password)) ? _clients[login] : throw new Exception("Такого пользователя нет в базе данных");

        public IOrderedEnumerable<KeyValuePair<int, List<Client>>> FindPiars(Client client, int maxAgeDif = 50)
        {
            var result = new SortedDictionary<int, List<Client>>();

            foreach (var c in ChoesToun(client, true))
            {
                var tempScore = client.ScoreIsPaerWithoutSexAndLocalization(c, maxAgeDif);

                if (tempScore >= 25)
                {
                    if (!result.ContainsKey(tempScore))
                    {
                        result.Add(tempScore, new List<Client>());
                    }

                    result[tempScore].Add(c);
                }
            }
            return result.OrderByDescending(kvp => kvp.Key);
        }

        public bool DeleteAdmin(Admin admin)
        {
            if (IsMyAdmin(admin))
            {
                _admins.Remove(admin.Login);

                return true;
            }
            else
            {
                throw new Exception("Такого админа нет или неправильный пароль");
            }
        }

        public void DeleteClientByClient(Client client)
        {
            DeleteClient(client);
        }

        public bool DeleteClientByAdmin(Admin admin, string loginClient)
        {
            if (IsMyAdmin(admin))
            {
                if (_clients.ContainsKey(loginClient))
                {
                    DeleteClient(_clients[loginClient]);

                    return true;
                }
                else
                {
                    return false;
                }

            }
            else
            {
                throw new Exception("Вы не админ");
            }
        }

        private void DeleteClient(Client client)
        {
            _clients.Remove(client.Login);

            ChoesToun(client).Remove(client);
        }

		public void DeleteAllClient(Admin admin)
		{
			if (IsMyAdmin(admin))
			{
				_clients.Clear();

				_sortedClients.Clear();
			}
			else
			{
				throw new Exception("Вы не админ");
			}
		}

    }
}
