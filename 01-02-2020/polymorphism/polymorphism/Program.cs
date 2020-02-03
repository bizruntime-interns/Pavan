using System;

namespace polymorphism
{
    class cloud
    {
        public virtual void cloudservices()
        {
            Console.WriteLine("This are the cloud services");
        }
    }
    class saas : cloud
    {
        public override void cloudservices()
        {
            Console.WriteLine("This SAAS services provides : Applications");
        }
    }
    class paas : cloud
    {
        public override void cloudservices()
        {
            Console.WriteLine("This PAAS services provides : Platform to build apps");
        }
    }
    class iaas : cloud
    {
        public override void cloudservices()
        {
            Console.WriteLine("This IAAS services provides : Cloud services");
        }
    }
    class program
    {
        static void Main(String[] args)
        {
            cloud mysaas = new iaas();
            cloud myiaas = new paas();
            cloud mypaas = new saas();

            myiaas.cloudservices();
            mypaas.cloudservices();
            mysaas.cloudservices();

        }
    }
}