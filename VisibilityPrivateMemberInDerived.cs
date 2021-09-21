namespace InheritanceForSummerSchool
{
    public class PrivateVisibilityBase
    {
        private int privateMember = 2020;

        public class PrivateVisibilityDerived : PrivateVisibilityBase
        {
            public int UsePrivateMember()
            {
                return privateMember;
            }
        }
    }

    public class NotNestedClass : PrivateVisibilityBase
    {
        //public int UsePrivateMember()
        //{
        //    return this.privateMember;
        //}
    }
}