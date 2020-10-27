using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPARATION_TELEPHONE
{
    public class reparationphone //je vais créer ma nouvelle classe qui s'appelle reparationphone
    {
        public string nom { get; set; }//je vais attribuer les variables nom, prénom, modelphone, mobile, email....
        public string prenom { get; set; }
        public string modelphone { get; set; }
        public int mobile { get; set; }
        public string email { get; set; }
        public DateTime dateRecue { get; set; }
        public string description { get; set; }
        public string statut { get; set; }
        public string textEstimation { get; set; }
        public string reparationAeffectuer { get; set; }
        public int prixReparation { get; set; }
        public DateTime editionFact { get; set; }
        public string prixEnLettres { get; set; }
        public string phoneDetail { get; set; }

        public reparationphone
           ( string nom, string prenom, string modelphone, int mobile, string email)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.modelphone = modelphone;
            this.mobile = mobile;
            this.email = email;
        }

    }
}
