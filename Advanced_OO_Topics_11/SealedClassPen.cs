namespace Advanced_OO_Topics_11
{
    public sealed class SealedClassPen
    {
        public string Type { get; set; }
        
        public SealedClassPen(string type)
        {
            Type = type;
        }
    }
    
    // Class LittlePen can't inherited from SealedClassPen because it has modificator SEALED
    
    // public class LittlePen : SealedClassPen
}