﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetSymfoCS.Metier;

namespace ProjetSymfoCS_Console
{
    internal static class AjoutPersonne
    {
        public static void AjouterPersonne()
        {
            Console.WriteLine("Entrez votre nom: ");
            string nom = Console.ReadLine();
            Console.WriteLine("Entrez votre prenom: ");
            string prenom = Console.ReadLine();

            Personne_Metier personne = new Personne_Metier(nom, prenom);
            
            
            Console.ReadLine();
        }
        public static void GetAll(int id)
        {
            string nom = "Terrieur";
            string prenom = "Alain";
            Personne_Metier personne = new Personne_Metier(nom, prenom);
            personne.GetAll(id);
        }
        public static int GetNbParticipant(int id)
        {
            string nom = "Terrieur";
            string prenom = "Alain";
            Personne_Metier personne = new Personne_Metier(nom, prenom);
            return personne.GetNbParticipant(id);
        }
        public static List<string> GetNom(int id)
        {
            string nom = "Terrieur";
            string prenom = "Alain";
            Personne_Metier personne = new Personne_Metier(nom, prenom);
            return personne.GetNom(id);
        }
    }

}
