using System;
using System.Collections.Generic;
using Microsoft.Practices.Unity;


namespace DependencyInjection
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = new UnityContainer();
            container.RegisterType<IDBAccess, SQLDataAccess>();
            Blogger blogger = container.Resolve<Blogger>();
        }
    }


    class Blogger
    {
        public string Name { get; set; }


        IDBAccess _DBAccess;
        public Blogger(IDBAccess DBAccess)
        {
            _DBAccess = DBAccess;
        }
    }


        interface IDBAccess
        {
            string connection { get; set; }
        }

        class SQLDataAccess : IDBAccess
        {

            public string _connection;
            public string connection
            {
                get
                {
                return "successful connection";
                }
                set
                {
                    _connection = value;
                }
            }
        }
}
