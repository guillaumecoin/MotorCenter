using System;
using System.Collections.Generic;
using System.Data.Entity;
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
            var liste = listeP.Where(p=>p.)
        }

        public voiture ModifierVoiture(voiture voiture)
        {
            voiture voitureAModifier = RechercherVoiture(voiture.idVoiture);
            if (voitureAModifier == null)
                return null;

            voitureAModifier.modeleId = voiture.modeleId;
            voitureAModifier.idCarburant = voiture.idCarburant;
            voitureAModifier.idPeinture = voiture.idPeinture;
            voitureAModifier.nbPorte = voiture.nbPorte;
            voitureAModifier.puissanceFiscale = voiture.puissanceFiscale;
            voitureAModifier.criterePollution = voiture.criterePollution;
            voitureAModifier.typeTransmission = voiture.typeTransmission;
            voitureAModifier.prix = voiture.prix;
            voitureAModifier.finition = voiture.finition;

            //statut de l'entité à "Modifiée" dans l'ORM
            context.Entry(voitureAModifier).State = EntityState.Modified;

            if (context.SaveChanges() > 0)
                return voitureAModifier;

            return null;
        }

        public bool SupprimerVoiture (int id)
        {
            voiture v = RechercherVoiture(id);

            if (v == null)
                return false;

            return SupprimerVoiture(v);
        }

        private bool SupprimerVoiture(voiture voiture)
        {
            if (voiture != null)
            {
                context.voitures.Remove(voiture);
                return (context.SaveChanges() > 0);
            }

            return false;
        }
    }
}
