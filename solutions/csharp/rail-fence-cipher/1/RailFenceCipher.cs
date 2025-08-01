public class RailFenceCipher
{
    private int rails;
    public RailFenceCipher(int rails)
    {
        this.rails = rails;
    }

    private int[] ToRail(int length){
        (int rail,int change) = (0,1);
        int[] toRail = new int[length];
        for(int i=0;i<length;++i){
            toRail[i] = rail;
            (rail,change) = NextRail(rail,change);
        }
        return toRail;
    }
    
    private (int rail,int change) NextRail(int rail,int change){
        if(rail == 0){
            change = +1;
        }
        else if(rail == this.rails - 1){
            change = -1;
        }
        rail += change;
        return (rail,change);
    }
    
    public string Encode(string input)
    {
        int[] toRail = ToRail(input.Length);
        char[] encoding = new char[input.Length];
        int index = 0;
        for(int i=0;i<this.rails;++i){
            for(int j=0;j<toRail.Length;++j){
                if(toRail[j] == i){
                    encoding[index] = input[j];
                    ++index;
                }
            }
        }
        return new string(encoding);
    }

    public string Decode(string input)
    {
        int[] railSize = new int[this.rails];
        (int rail,int change) = (0,1);
        for(int i=0;i<input.Length;++i){
            railSize[rail]++;
            (rail,change) = NextRail(rail,change);
        }
        int[] railIndex = new int[this.rails];
        int[] railStart = new int[this.rails];
        for(int i=1;i<this.rails;++i){
            railStart[i] = railStart[i - 1] + railSize[i - 1];
        }
        
        char[] encoding = new char[input.Length];
        (rail,change) = (0,1);
        for(int index=0;index<encoding.Length;++index){
            encoding[index] = input[railStart[rail] + railIndex[rail]];
            ++railIndex[rail];
            (rail,change) = NextRail(rail,change);
        }
        return new string(encoding);
    }
}