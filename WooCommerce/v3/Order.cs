using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using WooCommerceNET.Base;

namespace WooCommerceNET.WooCommerce.v3
{
    public class OrderBatch : BatchObject<Order> { }

    [DataContract]
    public class Order : v2.Order 
    {
        /// <summary>
        /// List of Pw Gift Card Redeemed Lines. See Order - Refunds properties 
        /// read-only
        /// </summary>
        /// CFC Added
        [DataMember( EmitDefaultValue = false )]
        public List<PwGiftCardRedeemedLine> pw_gift_cards_redeemed { get; set; }
    }

    /// CFC Added
    [DataContract]
    public class PwGiftCardRedeemedLine: JsonObject
    {
        /// <summary>
        /// Gift Card Number 
        /// </summary>
        [DataMember(EmitDefaultValue = false)]
        public string number { get; set; }

        /// <summary>
        /// Amount as a string
        /// </summary>
        [DataMember( EmitDefaultValue = false )]
        public string amount { get; set; }
    }


}
