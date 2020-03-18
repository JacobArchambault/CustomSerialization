using System;
using System.Runtime.Serialization;

namespace CustomSerialization
{
    [Serializable]
    class MoreData
    {
        private string dataItemOne = "First data block";
        private string dataItemTwo = "More data";

        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            // Called during the serialization process.
            dataItemOne = dataItemOne.ToUpper();
            dataItemTwo = dataItemTwo.ToUpper();
        }
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            // Called once the deserialization process is complete.
            dataItemOne = dataItemOne.ToLower();
            dataItemTwo = dataItemTwo.ToLower();
        }
    }
}
