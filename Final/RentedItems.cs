using System.Xml.Linq;

namespace Final
{
    public class RentedItems
    {
        public int itemId;
        public int tenantId;

        public RentedItems(int itemId, int tenantId)
        {
            this.itemId = itemId;
            this.tenantId = tenantId;
        }
        public override string ToString()
        {
            return $"ItemId: {itemId} TenantID: {tenantId};";
        }
    }


}
