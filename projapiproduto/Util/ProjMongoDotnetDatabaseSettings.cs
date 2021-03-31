namespace projapiproduto.Util
{
    public class ProjMongoDotnetDatabaseSettings : IProjMongoDotnetDatabaseSettings
    {
         public string ProdutoCollectionName { get; set; }
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
    }
}