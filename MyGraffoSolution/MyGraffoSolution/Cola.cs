using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyGraffoSolution
{
    public class Cola
    {
        public class Nodo
        {
            public string info;
            public Nodo sig1;
            public Nodo sig2;
            public Nodo sig3;

        }
        
        
        private Nodo raiz, fondo;

        public Cola()
        {
            raiz = null;
            fondo = null;
        }

        public bool Vacia()
        {
            if (raiz == null)
                return true;
            else
                return false;
        }
        public Nodo crearnodo(string info)
        {
            Nodo nodo;
            nodo = new Nodo();
            nodo.info = info;
            nodo.sig1 = null;
            nodo.sig2 = null;
            nodo.sig3 = null;
            return nodo;
        }
        public void Insertar(string info, string derecha, string medio, string izquierda)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig1 = null;
            nuevo.sig2 = null;
            nuevo.sig3 = null;
            //if (Vacia())
            //{
            //    raiz = nuevo;
            //    fondo = nuevo;
            //}
            //else
            //{    
            raiz = nuevo;
            fondo = nuevo;
                fondo.sig1 = crearnodo(derecha);                
                fondo.sig2 = crearnodo(medio);
                fondo.sig3 = crearnodo(izquierda);               
                fondo = nuevo;
            //}
        }

        public void Insertar(string info)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig1 = null;
            nuevo.sig2 = null;
            nuevo.sig3 = null;
            raiz = nuevo;
            fondo = nuevo;
            
        }

        public void Insertar(string info, string medio)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig1 = null;
            nuevo.sig2 = null;
            nuevo.sig3 = null;
            if (Vacia())
            {
                raiz = nuevo;
                fondo = nuevo;
            }
            else
            {
                Nodo reco = raiz;
                while (reco != null)
                {
                    if (medio == reco.info)
                    {
                        fondo.sig1 = reco;
                        break;
                    }
                    reco = reco.sig1;
                }
                fondo = nuevo;
            }
        }
        public void Insertar(string info, string medio, string derecha)
        {
            Nodo nuevo;
            nuevo = new Nodo();
            nuevo.info = info;
            nuevo.sig1 = null;
            nuevo.sig2 = null;
            nuevo.sig3 = null;
            if (Vacia())
            {
                raiz = nuevo;
                fondo = nuevo;
            }
            else
            {
                Nodo reco = raiz;
                while (reco != null)
                {
                    if (derecha == reco.info)
                    {
                        fondo.sig1 = reco;
                        break;
                    }
                    reco = reco.sig1;
                }
                while (reco != null)
                {
                    if (medio == reco.info)
                    {
                        fondo.sig1 = reco;
                        break;
                    }
                    reco = reco.sig1;
                }
                fondo = nuevo;
            }
        }
        public string Extraer()
        {
            if (Vacia())
            {
                string informacion = raiz.info;
                if (raiz == fondo)
                {
                    raiz = null;
                    fondo = null;
                }
                else
                {
                    raiz = raiz.sig1;
                }
                return informacion;
            }
            else
            {
                return "la lista no contiene elementos";

            }
        }
        public void Imprimir()
        {
            Nodo reco = raiz;
            Console.WriteLine("Listado de todos los elementos de la cola.");
            while (reco != null)
            {
                Console.Write(reco.info + "-");
                reco = reco.sig1;
            }
            Console.WriteLine();
        }
        //public List<Nodo> AgregarListadeNodos(Nodo nodoini)
        //{
        //    List < Nodo > lista= new List<Nodo>();            
        //    try
        //    {                
        //        lista.Add(nodoini);
        //    }
        //    catch (Exception)
        //    {

        //    }
        //    return lista;
        //}
        //public void agregarNodo(int info, Nodo nodo)
        //{
        //    Nodo nodoini = new Nodo();
        //    nodoini.info = info;
        //    nodoini.sig = nodo;
        //    AgregarListadeNodos(nodoini);

        //}
        List<string> listarutas = new List<string>();

        List<string> listaconocidos = new List<string>();
        public void mostrarelmentosdeunalista()
        {
            foreach(string elemento in listarutas)
            {
                Console.Write("Elemeto:");
                Console.WriteLine(elemento);
            }

        }

        public void AgragarLista(string ruta)
        {
            listarutas.Add(ruta);
        }
        public void EliminarLista(string ruta)
        {
            listarutas.Remove(ruta);
        }
        public void AgragarListaconocidos(string ruta)
        {
            listaconocidos.Add(ruta);
        }

        public string verificadorderutas(string nodo, string obj)
        {
            if (Vacia())
            {
                return "No existe la lista";
            }
            else
            {
                Nodo reco = raiz;
                while (reco.info != obj)
                {
                    if (reco.info != obj)
                    {
                        if (reco.sig1 == null) { }
                        else
                        {
                            AgragarLista(reco.sig1.info);
                        }
                        if (reco.sig2 == null) { }
                        else
                        {
                            AgragarLista(reco.sig2.info);
                        }
                        if (reco.sig3 == null) { }
                        else
                        {
                            AgragarLista(reco.sig3.info);
                        }
                        AgragarListaconocidos(reco.info);
                    }
                    reco = reco.sig1;
                }
                return "Objetivo alcazado";
            }            
        }
        public void nodoobj(string objetivo)
        {
            if (Vacia())
            {
                Nodo reco = raiz;
                while (reco != null)
                {
                    if (reco.info == objetivo)
                    {
                        Console.WriteLine("llegaste al nodo objetivo");
                    }
                    reco = reco.sig1;
                }
            }
        }

     
    }
}
