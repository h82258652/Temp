using GalaSoft.MvvmLight.Messaging;
using System;
using System.Collections.Generic;

namespace AiXiFan.Uwp.Messages
{
    public class UpdateCountsLoadedMessage : MessageBase
    {
        public UpdateCountsLoadedMessage(IDictionary<int, int> updateCounts)
        {
            if (updateCounts == null)
            {
                throw new ArgumentNullException(nameof(updateCounts));
            }

            UpdateCounts = updateCounts;
        }

        public IDictionary<int, int> UpdateCounts
        {
            get;
        }
    }
}