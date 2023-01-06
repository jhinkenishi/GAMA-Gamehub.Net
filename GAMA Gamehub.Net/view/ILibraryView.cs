using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GAMA_Gamehub.view
{
    public delegate void InsertProductHandler(string productId, string productName, string publisher, double price);
    public delegate void DeleteProductHandlerById(int productId);
    public delegate void DeleteProductHandlerByName(string productName);
    public delegate void UpdateProductHandlerById(int productId, string newProductName, string newPublisher, double price);
    public delegate void UpdateProductHandlerByName(string productName, string newProductName, string newPublisher, double price);
    public delegate void SelectProductHandler(int productId);

    public interface ILibraryView : GGView
    {
        event InsertProductHandler? OnInsert;
        event DeleteProductHandlerById? OnDelete;
        event DeleteProductHandlerByName? OnDeleteByName;
        event UpdateProductHandlerById? OnUpdateProductById;
        event UpdateProductHandlerByName? OnUpdateProductByName;
        event SelectProductHandler? OnSelectProductHandler;
    }
}
