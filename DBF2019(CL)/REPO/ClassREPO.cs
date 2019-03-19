using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace REPO
{
    public class ClassREPO : ClassNotify
    {
        //Fields
        #region Fields
        private int _ID;
        private string _Type;
        private string _Genre;
        private string _Forlag;
        private string _Forfattere;
        private DateTime _UdgivelsesDage;
        private string _Titel;
        private int _ISBNNummer;
        #endregion
        public ClassREPO(int inID , string inType, string inGenre, string inForlag,string inForfattere, DateTime inUdgivelsesDag, string inTitel, int inISBNNummer)
        {
            inID = ID;
            inType = Type;
            inGenre = Genre;
            inForlag = Forlag;
            inForfattere = Forfattere;
            inUdgivelsesDag = UdgivelsesDag;
            inTitel = Titel;
            inISBNNummer = ISBNNummer;
        }
        public ClassREPO()
        {

        }
        //Properties
        #region Properties
        public int ID
        {
            get { return _ID; }
            set
            {
                if (value != _ID)
                {
                    _ID = value;
                    Notify("ID");

                }
            }
        }
        public string Type
        {
            get { return _Type; }
            set
            {
                if (value != _Type)
                {
                    _Type = value;
                    Notify("Type");

                }
            }
        }        
        public string Genre
        {
            get { return _Genre; }
            set
            {
                if (value != _Genre)
                {
                    _Genre = value;
                    Notify("Genre");

                }
            }
        }       
        public string Forlag
        {
            get { return _Forlag; }
            set
            {
                if (value != _Forlag)
                {
                    _Forlag = value;
                    Notify("Forlag");

                }
            }
        }       
        public string Forfattere
        {
            get { return _Forfattere; }
            set
            {
                if (value != _Forfattere)
                {
                    _Forfattere = value;
                    Notify("Forfattere");

                }
            }
        }        
        public DateTime UdgivelsesDag
        {
            get { return _UdgivelsesDage; }
            set
            {
                if (value != _UdgivelsesDage)
                {
                    _UdgivelsesDage = value;
                    Notify("UdgivelsesDag");

                }
            }
        }        
        public string Titel
        {
            get { return _Titel; }
            set
            {
                if (value != _Titel)
                {
                    _Titel = value;
                    Notify("Titel");

                }
            }
        }      
        public int ISBNNummer
        {
            get { return _ISBNNummer; }
            set
            {
                if (value != _ISBNNummer)
                {
                    _ISBNNummer = value;
                    Notify("ISBNNummer");

                }
            }
        }
        #endregion

    }
}
