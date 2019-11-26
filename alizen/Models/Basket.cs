using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

using System;
using System.Collections.Generic;
using System.Text;

namespace alizen.Models
{
    public class Basket
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]
        public string _Id { get; set; }
        
        [BsonElement("Title")]
        private string CodProduct { get; set; }
        private string DesProduct { get; set; }
        private string CodCategoria { get; set; }
        private double PreProduct { get; set; }
        private int CanProduct { get; set; }
        private string Imagen { get; set; }

        public Client Client {get;set;}
        public List<KeyValuePair<Product, int>> Products { get; set; }


        public Basket(Client client) {
            Client = client;
            Products = new List<KeyValuePair<Product, int>> { };
        }
    }

}


/*
    public class Ventas{
        private string _codproducto;
        private string _desproducto;
        private string _codcategoria;
        private double _preproducto;
        private int _canproducto;
        private string _imagen;

        public Ventas(string ccodigo){
            _codigo = ccodigo;
        }
    

        public Ventas(
            string ccodigo,
            string cfecha,
            decimal csubtotal,
            decimal civg,
            decimal ctotal,
            string ccliente 
            ){
                _codigo=ccodigo;
                _fecha=cfecha;
                _subtotal=csubtotal;
                _igv=civg;
                _total=ctotal;
                _cliente=ccliente;
        }

        public string CodProducto{
            get{
                return _codproducto;
            }
            set{
                _codproducto=value;
            }
        }

        public string DesProducto{
            get{
                return _desproducto;
            }
            set{
                _desproducto;
            }
        }

        public string CodCategoria{
            get{
                return _codcategoria;
            }
            set{
                _codcategoria;
            }
        }

        public string PreProducto{
            get{
                return _preproducto;
            }
            set{
                _preproducto;
            }
        }

        public string CanProducto{
            get{
                return _canproducto;
            }
            set{
                _canproducto;
            }
        }

        
 */
