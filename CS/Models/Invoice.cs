using System;
using System.Collections.Generic;
using System.ComponentModel;

public class Invoice {
    public int? Id { get; set; }
    public string Description { get; set; }
    public decimal? Price { get; set; }
    public DateTime? RegisterDate { get; set; }

    [DataObjectMethod(DataObjectMethodType.Select)]
    public static List<Invoice> GetData() {
        List<Invoice> invoices = new List<Invoice>();
        const int count = 3;

        for (int i = 0; i < count; i++) {
            invoices.Add(new Invoice() {
                Id = i,
                Description = "Invoice" + i.ToString(),
                Price = i * 10,
                RegisterDate = DateTime.Today.AddDays(i - count)
            });
        }

        return invoices;
    }
}