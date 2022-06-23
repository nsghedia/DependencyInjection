namespace DIinject
{
    internal class BL
    {
        public IProduct _product;
        public BL(IProduct product)
        {
            _product = product;
        }
        public void insert()
        {
            _product.Insertdata();
        }
    }
}
