using System;
using DesignPattern.AbstractFactoryPattern;
using DesignPattern.AbstractFactoryPattern.ConcreteFactory;
using DesignPattern.AB;
using DesignPattern.ABFVechicle.ConcreteFactory;

namespace DesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Abstract Factory Design Pattern Mobiles
            /*
             We need to Choose Abstract Factory Pattern?
                 1)whenThe application need to create multiple families of objects or products
                 2) We need to use only one of the subset of families of objects at a given point of time
                 3) We want to hide the implementations of the families of products by decoupling the implementation of each of these operations
              */

            IMobilePhone_ABFactory nokiaMobilePhone = new Nokia(); //interface explict conversion
            MobileClient nokiamobileclient = new MobileClient(nokiaMobilePhone);// this class constructor expect Interface
            Console.WriteLine("*****************Nokia Mobiles*****************");
            Console.WriteLine(nokiamobileclient.getnormalphonedetails());
            Console.WriteLine(nokiamobileclient.getsmartphonedetails());

            //New functionality added Moto mobile details also need to add
            Console.WriteLine("**************Moto Mobiles*****************");
            IMobilePhone_ABFactory MotoMobilePhones = new Moto();
            MobileClient motoclient = new MobileClient(MotoMobilePhones);
            Console.WriteLine(motoclient.getnormalphonedetails());
            Console.WriteLine(motoclient.getsmartphonedetails());
            #endregion

            Console.WriteLine("*****************************************************************");
            #region Abstrct Factory Pattren Vechicles
            IABFactoryBikes bajajBikes = new Bajaj();
            VechicleClient bajajClient = new VechicleClient(bajajBikes);
            Console.WriteLine("**************Bajaj Bikes*****************");
            Console.WriteLine(bajajClient.GetNormalBike());
            Console.WriteLine(bajajClient.GetScooty());
            Console.WriteLine(bajajClient.GetSportsBike());
           

            #endregion
            Console.ReadLine();
        }
    }
}
