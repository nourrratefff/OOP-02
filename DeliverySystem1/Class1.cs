namespace DeliverySystem
{
    public class DeliveryCenter
    {
        private Shipment[] shipments = new Shipment[10];
        private int count = 0;

        public DeliveryCenter()
        {

        }

        #region Integer Indexer
        public Shipment this[int position]
        {
            get
            {
                if (position < 0 || position >= shipments.Length)
                {
                    return default(Shipment);
                }

                return shipments[position];
            }
            set
            {
                if (position >= 0 && position < shipments.Length)
                {
                    shipments[position] = value;
                }
            }
        }
        #endregion

        #region String Indexer 
        public Shipment this[string trackingCode]
        {
            get
            {
                for (int i = 0; i < shipments.Length; i++)
                {
                    if (shipments[i].ToString() == trackingCode)
                    {
                        return shipments[i];
                    }
                }

                return default(Shipment);
            }
        }
        #endregion

        #region Method
        public bool AddShipment(Shipment shipment)
        {
            if (count < shipments.Length)
            {
                shipments[count] = shipment;
                count++;
                return true;
            }

            return false;
        }
        #endregion
    }

    public struct Shipment
    {

    }
}