using ProjetoWeb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjetoWeb1.Services
{
    public class ProdutosService
    {

        public void CadastrarProdutos(Produtos produtos)
        {
            ProjetoContext dbContext = new ProjetoContext();
            var isValidateProduts = dbContext.Produtos.Where(x => x.Codigo == produtos.Codigo).Any();
            if (!isValidateProduts)
            {
                dbContext.Produtos.Add(produtos);
                dbContext.SaveChanges();
            }
            
        }

        public List<Produtos> ListarProdutosService()
        {
            using (var dbContext = new ProjetoContext())
            {
                var consultaProdutos = dbContext.Produtos.ToList();

                return consultaProdutos;
            }
        }
        public bool DeletarProdutosService(Produtos produtos)
        {

            using (var dbContext = new ProjetoContext())
            {
                var isValidateProduts = dbContext.Produtos.Where(x => x.Codigo == produtos.Codigo).Any();

                if (isValidateProduts)
                {
                    var produts = dbContext.Produtos.Where(x => x.Codigo == produtos.Codigo).FirstOrDefault();
                    dbContext.Produtos.Remove(produts);
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }


            }
            
        }
        public bool AtualizaProdutosService(Produtos produtos)
        {
            using (var dbContext = new ProjetoContext())
            {
                var isValidateProduts = dbContext.Produtos.Where(x => x.Codigo == produtos.Codigo).Any();

                if (isValidateProduts)
                {
                    var produts = dbContext.Produtos.Where(x => x.Codigo == produtos.Codigo).FirstOrDefault();
                    produts.Nome = produtos.Nome;
                    produts.Valor = produtos.Valor;
                    dbContext.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
                
            }
        }

    }
}