using System;

namespace InterfaceDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            var docStore = new Document();
            docStore.Read();
            docStore.Status = 69;
            //Print(docStore);

            var fileStore = new FlatFile();
            fileStore.Read();
            //Print(fileStore);
            fileStore.Print();

            var compressStore = fileStore as ICompressable;
            compressStore.Print();

            IStorable dumStore = docStore;
            dumStore.Read();

            if(dumStore is FlatFile)
            {
                var dum2Store = (FlatFile)dumStore;
                Print(dum2Store);
            }

            var dum3store = dumStore as FlatFile;
            if(dum3store != null)
            {
                Print(dum3store);
            }


        }

        static void Print(IStorable store)
        {
            store.Read();
        }
    }
}
