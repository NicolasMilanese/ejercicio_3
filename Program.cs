using System;


namespace ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
          Console.ForegroundColor=ConsoleColor.Magenta;
          Console.Clear();

            string lunes,martes,miercoles,jueves,viernes,sabado,domingo;
            int lunes1,martes2,miercoles3,jueves4,viernes5,sabado6,domingo7;
            
            
       Console.WriteLine("ingrese la temperatura del dia lunes ");
          lunes=Console.ReadLine();
          lunes1=Convert.ToInt32(lunes);

          Console.WriteLine("ingrese la temperatura del dia martes ");
         martes=Console.ReadLine();
         martes2=Convert.ToInt32(martes);

          Console.WriteLine("ingrese la temperatura del dia miercoles ");
          miercoles=Console.ReadLine();
          miercoles3=Convert.ToInt32(miercoles);

          Console.WriteLine("ingrese la temperatura del dia jueves ");
          jueves=Console.ReadLine();
          jueves4=Convert.ToInt32(jueves);

          Console.WriteLine("ingrese la temperatura del dia viernes ");
          viernes=Console.ReadLine();
          viernes5=Convert.ToInt32(viernes);

          Console.WriteLine("ingrese la temperatura del dia sabado ");
          sabado=Console.ReadLine();
          sabado6=Convert.ToInt32(sabado);

          Console.WriteLine("ingrese la temperatura del dia domingo ");
          domingo=Console.ReadLine();
          domingo7=Convert.ToInt32(domingo);
       
        if (lunes1 >= martes2 & lunes1 >= miercoles3 & lunes1 >= jueves4 & lunes1 >= viernes5 & lunes1 >= sabado6 & lunes1 >= domingo7)
        {
          Console.WriteLine("La temperatura Máxima es del dia lunes de: " + lunes1 + " grados");
          
        }
        if (martes2 >= lunes1 & martes2 >= miercoles3 & martes2 >= jueves4 & martes2 >= viernes5 & martes2 >= sabado6 & martes2 >= domingo7)
        {
          Console.WriteLine("La temperatura Máxima es del dia martes de: " + martes2 + " grados");
        }

        if (miercoles3 >= lunes1 & miercoles3 >= martes2 & miercoles3 >= jueves4 & miercoles3 >= viernes5 & miercoles3 >= sabado6 & miercoles3 >= domingo7)
        {
          Console.WriteLine("La temperatura Máxima es del dia miercoles de: " + miercoles3 + " grados");
        }

        if (jueves4 >= lunes1 & jueves4 >= martes2 & jueves4 >= miercoles3 & jueves4 >= viernes5 & jueves4 >= sabado6 & jueves4 >= domingo7)
        {
          Console.WriteLine("La temperatura Máxima es del dia jueves de: " + jueves4 + " grados");
        }

        if (viernes5 >= lunes1 & viernes5 >= martes2 & viernes5 >= miercoles3 & viernes5 >= jueves4 & viernes5 >= sabado6 & viernes5 >= domingo7)
        {
          Console.WriteLine("La temperatura Máxima es del dia viernes de: " + viernes5 + " grados");
        }

        if (sabado6 >= lunes1 & sabado6 >= martes2 & sabado6 >= miercoles3 & sabado6 >= jueves4 & sabado6 >= viernes5 & sabado6 >= domingo7)
        {
          Console.WriteLine("La temperatura Máxima es del dia sabado de: " + sabado6 + " grados");
        }

        if (domingo7 >= lunes1 & domingo7 >= martes2 & domingo7 >= miercoles3 & domingo7 >= jueves4 & domingo7 >= viernes5 & domingo7 >= sabado6)
        {
          Console.WriteLine("La temperatura Máxima es del dia domingo de: " + domingo7 + " grados");
        }


        if (lunes1 <= martes2 & lunes1 <= miercoles3 & lunes1 <= jueves4 & lunes1 <= viernes5 & lunes1 <= sabado6 & lunes1 <= domingo7)
        {
          Console.WriteLine("La temperatura Minima es del dia lunes de: " + lunes1 + " grados");
          
        }
        if (martes2 <= lunes1 & martes2 <= miercoles3 & martes2 <= jueves4 & martes2 <= viernes5 & martes2 <= sabado6 & martes2 <= domingo7)
        {
          Console.WriteLine("La temperatura Minima es del dia martes de: " + martes2 + " grados");
        }

        if (miercoles3 <= lunes1 & miercoles3 <= martes2 & miercoles3 <= jueves4 & miercoles3 <= viernes5 & miercoles3 <= sabado6 & miercoles3 <= domingo7)
        {
          Console.WriteLine("La temperatura Minima es del dia miercoles de: " + miercoles3 + " grados");
        }

        if (jueves4 <= lunes1 & jueves4 <= martes2 & jueves4 <= miercoles3 & jueves4 <= viernes5 & jueves4 <= sabado6 & jueves4 <= domingo7)
        {
          Console.WriteLine("La temperatura Minima es del dia jueves de: " + jueves4 + " grados");
        }

        if (viernes5 <= lunes1 & viernes5 <= martes2 & viernes5 <= miercoles3 & viernes5 <= jueves4 & viernes5 <= sabado6 & viernes5 <= domingo7)
        {
          Console.WriteLine("La temperatura Minima es del dia viernes de: " + viernes5 + " grados");
        }

        if (sabado6 <= lunes1 & sabado6 <= martes2 & sabado6 <= miercoles3 & sabado6 <= jueves4 & sabado6 <= viernes5 & sabado6 <= domingo7)
        {
          Console.WriteLine("La temperatura Minima es del dia sabado de: " + sabado6 + " grados");
        }

        if (domingo7 <= lunes1 & domingo7 <= martes2 & domingo7 <= miercoles3 & domingo7 <= jueves4 & domingo7 <= viernes5 & domingo7 <= sabado6)
        {
          Console.WriteLine("La temperatura Minima es del dia domingo de: " + domingo7 + " grados");
        }
     
        }
    }
}
