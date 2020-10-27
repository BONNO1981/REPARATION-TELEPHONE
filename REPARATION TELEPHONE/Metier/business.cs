using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPARATION_TELEPHONE.Metier


{

    public class Business
    {
        public static ObservableCollection<reparationphone> PhoneRepair { get; }
    
        static Business()
        {
            PhoneRepair = new ObservableCollection<reparationphone>();
            //je vais créer ma liste de réparation avec les informations des clients
            reparationphone Gilles = new reparationphone("BONNO", "Gilles", "Alcatel", 87238326, "hiriken2001@gmail.com" );
            reparationphone Mylene = new reparationphone("BONNO", "Mylene", "Samsung", 87323536, "mylene25@gmail.com"    );
            reparationphone Havekua = new reparationphone("BONNO", "Havekua", "Nokia", 87253265, "havekua2015@gmail.com" );
            reparationphone Alida = new reparationphone("BONNO", "Alida", "Blackview", 87315645, "alida1995@gmail.com"   );
            reparationphone Shirley = new reparationphone("BONNO", "Shirley", "Sony", 87295685, "hiriata2003@gmail.com"  );
            reparationphone Nemmaly = new reparationphone("BONNO", "Nemmaly", "Apple", 87362514, "nemmaly184@gmail.com"  );
            reparationphone Kenjiro = new reparationphone("BONNO", "Kenjiro", "Xperia", 87281213, "kenjiro2006@gmail.com");



            //j'ajoute ma liste de réparation à faire dans ma liste nouvellement créer 
            PhoneRepair.Add(Gilles);
            PhoneRepair.Add(Mylene);
            PhoneRepair.Add(Havekua);
            PhoneRepair.Add(Alida);
            PhoneRepair.Add(Shirley);
            PhoneRepair.Add(Nemmaly);
            PhoneRepair.Add(Kenjiro);

        }
    
    }

}
