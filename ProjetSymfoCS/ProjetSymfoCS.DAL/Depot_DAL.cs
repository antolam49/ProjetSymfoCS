﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.Extensions.Configuration;

namespace ProjetSymfoCS.DAL
{
    public abstract class Depot_DAL<Type_DAL> : IDepot_DAL<Type_DAL>
    {

        public string ChaineDeConnexion { get; set; }

        protected SqlConnection connexion;
        protected SqlCommand commande;

        public Depot_DAL()
        {
            var builder = new ConfigurationBuilder();
            var config = builder.AddJsonFile("appsettings.json", false, true).Build();

            ChaineDeConnexion = config.GetSection("ConnectionStrings:default").Value;
        }

        protected void CreerConnectionCommande()
        {
            connexion = new SqlConnection(ChaineDeConnexion);
            connexion.Open();
            commande = new SqlCommand();
            commande.Connection = connexion;

        }

        protected void DetruireConnexion()
        {
            commande.Dispose();
            connexion.Close();
            connexion.Dispose();
        }


        #region Méthodes Abstraite
        public abstract List<Type_DAL> GetAll();

        public abstract Type_DAL GetByID(int ID);

        public abstract Type_DAL Insert(Type_DAL item);

        public abstract Type_DAL Update(Type_DAL item);

        public abstract void Delete(Type_DAL item);
        #endregion

    }
}
