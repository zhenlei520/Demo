namespace CSharp11.Switch;

public class SpeedComp
{
    public static int MatchExp(int[] array)
    {
        return array switch
        {
            [] => 1,
            [_, .. , 2] => 2,
            [_, int second] => second + 1,
            [_, .. int[] middle, _, _] => middle.Sum(),
            _ => -1,
        };
    }
}
