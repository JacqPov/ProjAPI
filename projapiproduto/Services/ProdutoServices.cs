using System.Collections.Generic;
using MongoDB.Driver;
using projapiproduto.Models;
using projapiproduto.Util;

namespace projapiproduto.Services
{
    public class ProdutoServices
    {
        private readonly IMongoCollection<Produto> _produtos;

        public ProdutoServices(IProjMongoDotnetDatabaseSettings settings)
        {
            var produto = new MongoClient(settings.ConnectionString);
            var database = produto.GetDatabase(settings.DatabaseName);
            _produtos = database.GetCollection<Produto>(settings.ProdutoCollectionName);
        }

        public List<Produto> Get() =>
            _produtos.Find(produto => true).ToList();

        public Produto Get(string id) =>
            _produtos.Find<Produto>(produto => produto.Id == id).FirstOrDefault();

        public Produto Create(Produto produto)
        {
            _produtos.InsertOne(produto);
            return produto;
        }

        public void Update(string id, Produto produtoIn) =>
            _produtos.ReplaceOne(produto => produto.Id == id, produtoIn);

        public void Remove(Produto produtoIn) =>
            _produtos.DeleteOne(produto => produto.Id == produtoIn.Id);

        public void Remove(string id) => 
            _produtos.DeleteOne(produto => produto.Id == id);   
    }
}