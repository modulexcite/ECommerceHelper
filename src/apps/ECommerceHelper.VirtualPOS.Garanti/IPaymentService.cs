﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECommerceHelper.VirtualPOS.Garanti {

    public interface IPaymentService : IDisposable {

        Task<PaymentResponseContext> ProcessSaleAsync(PaymentRequestContext paymentRequest);
    }
}