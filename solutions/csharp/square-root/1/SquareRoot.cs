public static class SquareRoot
{
    public static int Root(int number)
    {
        int rootMin = 1;
        int rootMax = number;
        while(rootMax - rootMin > 1){
            int tmp = (rootMin + rootMax) / 2;
            if (tmp * tmp <= number){
                rootMin = tmp;
            }
            else{
                rootMax = tmp;
            }
        }
        return rootMin;
    }
}
