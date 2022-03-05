using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorTest.Models
{
    class GestionVoiture
    {
        private MotorContext context = new MotorContext();

        public List<voiture>  ChargerVoiture()
        {
            return context.voitures.ToList();
        }

        public voiture AjouterVoiture(voiture voiture)
        {
            context.voitures.Add(voiture);

            if (context.SaveChanges() > 0)
                return voiture;

            return null;
        }

        public voiture RechercherVoiture (int id)
        {
            return context.voitures.Find(id);
        }

        public List<voiture> RechercherVoitureParNom (string name)
        {
            var listeP = context.voitures.AsEnumerable();
        }

    }
}
