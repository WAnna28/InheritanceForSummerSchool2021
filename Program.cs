using System;

namespace InheritanceForSummerSchool
{
    public class Program
    {
        public static void Main(string[] args)
        {
            /* Private members are visible only in derived classes that are nested in their base class.*/
            var pvd = new PrivateVisibilityBase.PrivateVisibilityDerived();
            Console.WriteLine(pvd.UsePrivateMember());

            /* Protected members are visible only in derived classes. */
            ProtectedVisibilityDerived protDerived = new ProtectedVisibilityDerived();
            Console.WriteLine(protDerived.UseProtectedMember());
            var protBase = new ProtectedVisibilityBase();
           // Console.WriteLine(protBase.protectedMember);

            /* Public members are visible in derived classes and are part of the derived class' public interface. */
            PublicVisibilityDerived publicDerived = new PublicVisibilityDerived();
            publicDerived.PublicMethod();

            ///* Implicit inheritance from the Object class makes these methods available */
            ImplicitInheritance i = new ImplicitInheritance();
           // i.
            ImplicitForStruct ss = new ImplicitForStruct();
            //ss.

            Console.ReadLine();
        }
    }

    /* Inheritance applies only to classes and interfaces. */
    //public struct InheritStructure : PublicVisibilityDerived
    //{
    //}
}