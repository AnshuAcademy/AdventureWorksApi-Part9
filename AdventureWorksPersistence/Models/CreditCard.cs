using System;
using System.Collections.Generic;

namespace AdventureWorksPersistence.Models
{
    /// <summary>
    /// Customer credit card information.
    /// </summary>
    public partial class CreditCard
    {
        public CreditCard()
        {
            PersonCreditCard = new HashSet<PersonCreditCard>();
            SalesOrderHeader = new HashSet<SalesOrderHeader>();
        }

        /// <summary>
        /// Primary key for CreditCard records.
        /// </summary>
        public int CreditCardID { get; set; }
        /// <summary>
        /// Credit card name.
        /// </summary>
        public string CardType { get; set; } = null!;
        /// <summary>
        /// Credit card number.
        /// </summary>
        public string CardNumber { get; set; } = null!;
        /// <summary>
        /// Credit card expiration month.
        /// </summary>
        public byte ExpMonth { get; set; }
        /// <summary>
        /// Credit card expiration year.
        /// </summary>
        public short ExpYear { get; set; }
        /// <summary>
        /// Date and time the record was last updated.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        public virtual ICollection<PersonCreditCard> PersonCreditCard { get; set; }
        public virtual ICollection<SalesOrderHeader> SalesOrderHeader { get; set; }
    }
}
