using System;
using FluentValidation.Results;
using Redakcija.WinClient.Models.Validators;

namespace Redakcija.WinClient.Models
{
    public class Clanak : Entity
    {
        private readonly ClanakValidator m_Validator = new ClanakValidator();
        private int? m_PublikacijaID;
        private int m_KreatorID;
        private int? m_RubrikaID;
        private DateTime m_Datum;
        private string m_Naslov;
        private byte[] m_Raw;

        public Clanak()
        {
            Datum = DateTime.Now;
        }

        public int KreatorID
        {
            get { return m_KreatorID; }
            set
            {
                if (value == m_KreatorID)
                {
                    return;
                }
                m_KreatorID = value;
                OnPropertyChanged("KreatorID");
            }
        }

        public int? PublikacijaID
        {
            get { return m_PublikacijaID; }
            set
            {
                if (value == m_PublikacijaID)
                {
                    return;
                }
                m_PublikacijaID = value;
                OnPropertyChanged("PublikacijaID");
            }
        }

        public int? RubrikaID
        {
            get { return m_RubrikaID; }
            set
            {
                if (value == m_RubrikaID)
                {
                    return;
                }
                m_RubrikaID = value;
                OnPropertyChanged("RubrikaID");
            }
        }

        public DateTime Datum
        {
            get { return m_Datum; }
            set
            {
                if (value.Equals(m_Datum))
                {
                    return;
                }
                m_Datum = value;
                OnPropertyChanged("Datum");
            }
        }

        public string Naslov
        {
            get { return m_Naslov; }
            set
            {
                if (value == m_Naslov)
                {
                    return;
                }
                m_Naslov = value;
                OnPropertyChanged("Naslov");
            }
        }

        public byte[] Raw
        {
            get { return m_Raw; }
            set
            {
                if (Equals(value, m_Raw))
                {
                    return;
                }
                m_Raw = value;
                OnPropertyChanged("Raw");
            }
        }

        protected override void OnPropertyChanged(string propertyName)
        {
            base.OnPropertyChanged(propertyName);
            switch (propertyName)
            {
                case "PublikacijaID":
                    RubrikaID = null;
                    break;
            }
        }

        protected override ValidationResult GetErrors()
        {
            return m_Validator.Validate(this);
        }
    }
}