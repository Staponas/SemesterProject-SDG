namespace InventorySystem
{
    public class Inventory
    {
        public List<string?> ?Items;
        public string? Name;

        public string? Description;

        public Inventory()
        {
            Items = new();

        }

        public void Add(string? item)
        {
            Items?.Add(item);
        }

        public void Remove(string? item)
        {
            Items?.Remove(item);
        }

        public void Display()
        {
            if(Items==null)
                return;
            foreach(var item in Items)
            {
                Console.WriteLine(item);
            }
        }

        public bool CheckForDevicePartEurope()
        {
            if(Items==null)
                return false;
            else
            {
                foreach(var item in Items)
                {
                    if(Items.Contains("devicePartEurope"))
                    {
                        return true;
                    }
                    
                }
                return false;
            }
        }

         public bool CheckForDevicePartAfrica()
        {
            if(Items==null)
                return false;
            else
            {
                foreach(var item in Items)
                {
                    if(Items.Contains("devicePartAfrica"))
                    {
                        return true;
                    }
                    
                }
                return false;
            }
        }

        public bool CheckForDevicePartAmerica()
        {
            if(Items==null)
                return false;
            else
            {
                foreach(var item in Items)
                {
                    if(Items.Contains("devicePartAmerica"))
                    {
                        return true;
                    }
                    
                }
                return false;
            }
        }

        public bool CheckForDevicePartAsia()
        {
            if(Items==null)
                return false;
            else
            {
                foreach(var item in Items)
                {
                    if(Items.Contains("devicePartAsia"))
                    {
                        return true;
                    }
                    
                }
                return false;
            }
        }
        public bool CheckForDevicePartOceania()
        {
            if(Items==null)
                return false;
            else
            {
                foreach(var item in Items)
                {
                    if(Items.Contains("devicePartOceania"))
                    {
                        return true;
                    }
                    
                }
                return false;
            }
        }
        public bool CheckForDevicePart4()
        {
            if(Items==null)
                return false;
            else
            {
                foreach(var item in Items)
                {
                    if(Items.Contains("devicePart4"))
                    {
                        return true;
                    }
                    
                }
                return false;
            }
        }

    }
}