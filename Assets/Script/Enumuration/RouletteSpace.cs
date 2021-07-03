using System.Collections.Generic;
public enum RouletteSpace
{
    Zero = 0,
    DoubleZero = 37,
}

public enum RouletteColor
{
    red,
    black,
    green,
}

public static class RouletteColorReference //We use hard code since Roulette Color convention won't change I guess
{
    public static RouletteColor getRouletteColor(RouletteSpace space)
    {
        RouletteColor color = new RouletteColor();
        if (space == RouletteSpace.Zero || space == RouletteSpace.DoubleZero)
        {
            color = RouletteColor.green;
        }
        else if (((int)space >= 1 && (int)space <= 10) || ((int)space >= 19 && (int)space <= 28))
        {
            if ((int)space % 2 == 1)
            {
                color = RouletteColor.red;
            }
            else
            {
                color = RouletteColor.black;
            }
        }
        else if (((int)space >= 11 && (int)space <= 18) || ((int)space >= 29 && (int)space <= 36))
        {
            if ((int)space % 2 == 1)
            {
                color = RouletteColor.black;
            }
            else
            {
                color = RouletteColor.red;
            }
        }
        else
        {
            color = RouletteColor.green;
        }

        return color;
    }
}
