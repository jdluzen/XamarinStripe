﻿/*
 * Copyright 2012 Xamarin, Inc.
 *
 * Licensed under the Apache License, Version 2.0 (the "License");
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an "AS IS" BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Newtonsoft.Json;

namespace Xamarin.Payments.Stripe {
    [JsonObject (MemberSerialization.OptIn)]
    public class StripeDiscount : StripeObject {
        [JsonProperty (PropertyName = "customer")]
        public string Customer { get; set; }

        [JsonProperty (PropertyName = "coupon")]
        public string Coupon { get; set; }

        [JsonProperty (PropertyName = "start")]
        [JsonConverter (typeof (UnixDateTimeConverter))]
        public DateTime? Start { get; set; }

        [JsonProperty (PropertyName = "end")]
        [JsonConverter (typeof (UnixDateTimeConverter))]
        public DateTime? End { get; set; }
    }
}
