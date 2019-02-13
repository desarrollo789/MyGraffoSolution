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
        public bool VacioReferancias(Nodo nodo)
        {
            if (nodo.sig1 == null && nodo.sig2 == null && nodo.sig3 == null)
            {
                return true;
            }
            else
            {
                return false;
            }
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

        public bool BusquedayAsignacion(string parametro, string orientacion)
        {
            if (Vacia())
            {
                return false;
            }
            else
            {
                Nodo reco1 = raiz;
                Nodo reco2 = raiz;
                Nodo reco3 = raiz;
                while (reco1.info != parametro || reco2.info != parametro || reco3.info != parametro)
                {
                    if (reco1.info != parametro) { }
                    else
                    {
                        try
                        {
                            if (orientacion == "izquierda")
                            {
                                fondo.sig1 = reco1;
                                fondo = reco1;
                                return true;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("orientacion no valida enviado");
                        }

                        try
                        {
                            if (orientacion == "medio")
                            {
                                fondo.sig2 = reco1;
                                fondo = reco1;
                                return true;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("orientacion no valida enviado");
                        }

                        try
                        {
                            if (orientacion == "derecha")
                            {
                                fondo.sig3 = reco1;
                                fondo = reco1;
                                return true;
                            }
                        }
                        catch
                        {
                            Console.WriteLine("orientacion no valida enviado");
                        }
                    }
                    if (reco2 != reco1)
                    {
                        if (reco2.info != parametro) { }
                        else
                        {
                            try
                            {
                                if (orientacion == "izquierda")
                                {
                                    fondo.sig1 = reco2;
                                    fondo = reco2;
                                    return true;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("orientacion no valida enviado");
                            }

                            try
                            {
                                if (orientacion == "medio")
                                {
                                    fondo.sig2 = reco2;
                                    fondo = reco2;
                                    return true;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("orientacion no valida enviado");
                            }
                            try
                            {
                                if (orientacion == "derecha")
                                {
                                    fondo.sig3 = reco2;
                                    fondo = reco2;
                                    return true;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("orientacion no valida enviado");
                            }
                        }
                    }
                    if (reco3 != reco1)
                    {
                        if (reco3.info != parametro) { }
                        else
                        {
                            try
                            {
                                if (orientacion == "izquierda")
                                {
                                    fondo.sig1 = reco3;
                                    fondo = reco3;
                                    return true;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("orientacion no valida enviado");
                            }

                            try
                            {
                                if (orientacion == "medio")
                                {
                                    fondo.sig2 = reco3;
                                    fondo = reco3;
                                    return true;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("orientacion no valida enviado");
                            }

                            try
                            {
                                if (orientacion == "derecha")
                                {
                                    fondo.sig3 = reco3;
                                    fondo = reco3;
                                    return true;
                                }
                            }
                            catch
                            {
                                Console.WriteLine("orientacion no valida enviado");
                            }
                        }
                    }

                    //linea de separacion

                    if (reco1.sig1 == null) { break; }
                    else { reco1 = reco1.sig1; }
                    if (reco1.sig2 == null) { break; }
                    else { reco2 = reco1.sig2; }
                    if (reco1.sig3 == null) { break; }
                    else { reco3 = reco1.sig3; }
                }

                return false;
            }
        }  
        
        public void Asignarsiguentealanterior(Nodo siguiente)
        {
            if (raiz.sig1 == null && raiz.sig1.info == siguiente.info)
            {
                raiz.sig1 = siguiente;
            }
            if (raiz.sig2 == null && raiz.sig2.info == siguiente.info)
            {
                raiz.sig2 = siguiente;
            }
            if (raiz.sig3 == null && raiz.sig3.info == siguiente.info)
            {
                raiz.sig3 = siguiente;
            }
        }

        public void Asignarsiguentealanterior(Nodo anterior, Nodo siguiente)
        {
            if (raiz.sig1 == null && raiz.sig1.info == siguiente.info)
            {
                raiz.sig1 = siguiente;
            }
            if (raiz.sig2 == null && raiz.sig2.info == siguiente.info)
            {
                raiz.sig2 = siguiente;
            }
            if (raiz.sig3 == null && raiz.sig3.info == siguiente.info)
            {
                raiz.sig3 = siguiente;
            }
        }
        public void asignacionfondoElementos(Nodo nuevo)
        {
            fondo = nuevo;
        }
        public void asignacionfondoElementos(Nodo nuevo, string izquierda)
        {
            //asignacion de izquierda
            if (BusquedayAsignacion(izquierda, "izquierda"))
            {
                
            }
            else
            {                
                
                fondo = nuevo;
                fondo.sig1 = crearnodo(izquierda);                
            }
            //fin asignacion de izquierda           
        }

        public void asignacionfondoElementos(Nodo nuevo, string izquierda, string medio)
        {
            //asignacion de izquierda
            if (BusquedayAsignacion(izquierda, "izquierda"))
            {
                
            }
            else
            {
                fondo = nuevo;                
                fondo.sig1 = crearnodo(izquierda);
            }
            //fin asignacion de izquierda
            //asignacion de medio
            if (BusquedayAsignacion(medio, "medio"))
            {
                
            }
            else
            {
                fondo = nuevo;
                fondo.sig2 = crearnodo(medio);
                
            }
            //fin asignacion de medio                   
        }
        public void asignacionfondoElementos(Nodo nuevo, string izquierda, string medio, string derecha)
        {
            //asignacion de izquierda
            if (BusquedayAsignacion(izquierda, "izquierda"))
            {
                
            }
            else
            {
                fondo = nuevo;
                fondo.sig1 = crearnodo(izquierda);                
            }
            //fin asignacion de izquierda
            //asignacion de medio
            if (BusquedayAsignacion(medio, "medio"))
            {
                
            }
            else
            {
                fondo = nuevo;
                fondo.sig2 = crearnodo(medio);                
            }
            //fin asignacion de medio 
            //asignacion de derecha
            if (BusquedayAsignacion(derecha, "derecha"))
            {
                
            }
            else
            {
                fondo = nuevo;
                fondo.sig3 = crearnodo(derecha);
            }
            //fin asignacion de derecha   
        }

        public void Insertar(string info)
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
                asignacionfondoElementos(nuevo);
            }
            else
            {
                asignacionfondoElementos(nuevo);
            }
        }

        public void Insertar(string info, string izquierda)
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
                asignacionfondoElementos(nuevo, izquierda);
            }
            else
            {
                asignacionfondoElementos(nuevo, izquierda);
            }
        }
        public void Insertar(string info, string izquierda, string medio)
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
                asignacionfondoElementos(nuevo, izquierda, medio);
            }
            else
            {
                asignacionfondoElementos(nuevo, izquierda, medio);
            }
        }

        public void Insertar(string info, string izquierda, string medio, string derecha)
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
                asignacionfondoElementos(nuevo, izquierda, medio, derecha);
            }
            else
            {
                asignacionfondoElementos(nuevo, izquierda, medio, derecha);
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
            Nodo reco1 = raiz;
            Nodo reco2 = raiz;
            Nodo reco3 = raiz;
            //Nodo reco4 = raiz;
            //Nodo reco5 = raiz;
            //Nodo reco6 = raiz;
            if (Vacia())
            {
                Console.WriteLine("No existe grafo");
            }
            else
            {
                while (reco1 != null || reco2 != null || reco3 != null)
                {
                    Console.WriteLine("Listado de todos los elementos de la cola.");
                    Console.WriteLine("Primera ruta");
                    while (reco1 != null)
                    {
                        Console.Write(reco1.info + "-");
                        reco1 = reco1.sig1;

                    }                    
                    Console.WriteLine(Environment.NewLine + "Segunda ruta");
                    while (reco2 != null)
                    {                        
                        Console.Write(reco2.info + "-");
                        reco2 = reco2.sig2;
                    }
                    Console.WriteLine(Environment.NewLine + "Tercera ruta");
                    while (reco3 != null)
                    {                        
                        Console.Write(reco3.info + "-");
                        reco3 = reco3.sig3;
                    }
                    Console.WriteLine();
                    if (reco1 == null)
                    {
                        reco1 = raiz;
                    }


                    //linea de separacion
                    if (reco1.sig2 == null) { break; }
                    else { reco2 = reco1.sig2; }
                    if (reco1.sig3 == null) { break; }
                    else { reco3 = reco1.sig3; }
                    if (reco1.sig1 == null) { break; }
                    else { reco1 = reco1.sig1; }
                    
                    //string lolo = "lolo";
                }                                                
            }
                    
           
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
                Nodo reco1 = raiz;
                Nodo reco2 = raiz;
                Nodo reco3 = raiz;
                while (reco1.info != obj || reco2.info != obj || reco3.info != obj)
                {
                    if (reco1.sig1 == null) { }
                    else
                    {
                        AgragarLista(reco1.info + reco1.sig1.info);
                    }
                    if (reco1.sig2 == null) { }
                    else
                    {
                        AgragarLista(reco1.info + reco1.sig2.info);
                    }
                    if (reco1.sig3 == null) { }
                    else
                    {
                        AgragarLista(reco1.info + reco1.sig3.info);
                    }
                    if (reco1 == null) { }
                    else { AgragarListaconocidos(reco1.info); }
                    if (reco2 != reco1 || reco2 != reco3)
                    {
                        if (reco2.sig1 == null) { }
                        else
                        {
                            AgragarLista(reco2.info + reco2.sig1.info);
                        }
                        if (reco2.sig2 == null) { }
                        else
                        {
                            AgragarLista(reco2.info + reco2.sig2.info);
                        }
                        if (reco2.sig3 == null) { }
                        else
                        {
                            AgragarLista(reco2.info + reco2.sig3.info);
                        }
                        if (reco2 == null) { }
                        else { AgragarListaconocidos(reco2.info); }
                    }
                    if (reco3 != reco1 || reco3 != reco2 )
                    {
                        if (reco3.sig1 == null) { }
                        else
                        {
                            AgragarLista(reco3.info + reco3.sig1.info);
                        }
                        if (reco3.sig2 == null) { }
                        else
                        {
                            AgragarLista(reco3.info + reco3.sig2.info);
                        }
                        if (reco3.sig3 == null) { }
                        else
                        {
                            AgragarLista(reco3.info + reco3.sig3.info);
                        }
                        if (reco3 == null) { }
                        else { AgragarListaconocidos(reco3.info); }
                    }              
                                        
                    //linea de separacion

                    if (reco1.sig1 == null) { }
                    else { reco1 = reco1.sig1; }
                    if (reco1.sig2 == null) { }
                    else { reco2 = reco1.sig2; }
                    if (reco1.sig3 == null) { }
                    else { reco3 = reco1.sig3; }
                    if (reco1.sig1 == null && reco1.sig2 == null && reco1.sig3 == null)
                    {
                        break;
                    }
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
