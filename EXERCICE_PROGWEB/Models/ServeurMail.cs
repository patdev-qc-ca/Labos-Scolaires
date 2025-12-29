using System.ComponentModel.DataAnnotations;
namespace Exercice_ProgWeb31.Models
{
    internal class ServeurMail
    {
        private int serveurID;
        private int mailID;
        private int recuDe;
        private int envoyeA;

        public ServeurMail(int serveurID, int mailID, int recuDe, int envoyeA)
        {
            this.serveurID = serveurID;
            this.mailID = mailID;
            this.recuDe = recuDe;
            this.envoyeA = envoyeA;
        }

        public ServeurMail()
        {
            this.serveurID += 1;
            this.mailID += 1;
        }

        [Key, Required]
        public int ServeurID { get => serveurID; set => serveurID = value; }
        public int MailID { get => mailID; set => mailID = value; }
        public int RecuDe { get => recuDe; set => recuDe = value; }
        public int EnvoyeA { get => envoyeA; set => envoyeA = value; }

    }
}