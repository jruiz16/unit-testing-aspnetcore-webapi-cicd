using web_api.Contracts;
using web_api.Model;

namespace web_api.Services
{
	public class ShoppingCartService : IShoppingCartService
	{
		private readonly List<ShoppingItem> _items;

		public ShoppingCartService()
		{
			_items = new List<ShoppingItem>();
		}

		public ShoppingItem Add(ShoppingItem newItem)
		{
			if (newItem == null)
				throw new ArgumentNullException(nameof(newItem));

			newItem.Id = Guid.NewGuid();
			_items.Add(newItem);
			return newItem;
		}

		public IEnumerable<ShoppingItem> GetAllItems()
		{
			return _items;
		}

		public ShoppingItem GetById(Guid id)
		{
			return _items.FirstOrDefault(item => item.Id == id);
		}

		public void Remove(Guid id)
		{
			var itemToRemove = _items.FirstOrDefault(item => item.Id == id);
			if (itemToRemove != null)
				_items.Remove(itemToRemove);
		}
	}
}
