using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_Light
{
    class pooAgenda
    {
        //Getters e Setters
        private String compromisso;

        public String Compromisso
        {
            get { return this.compromisso; }
            set { this.compromisso = value; }
        }

        private String dia;

        public String Dia
        {
            get { return this.dia; }
            set { this.dia = value; }
        }

        private String hora;

        public String Hora
        {
            get { return this.hora; }
            set { this.hora = value; }
        }

        private String local;

        public String Local
        {
            get { return this.local; }
            set { this.local = value; }
        }


        private String contato;

        public String Contato
        {
            get { return this.contato; }
            set { this.contato = value; }
        }


    }
}
