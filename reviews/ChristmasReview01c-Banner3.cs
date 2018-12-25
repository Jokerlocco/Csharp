// Jorge Calzada Asenjo

/*
    Write a banner in a console
*/

using System;

public class Banner
{
    public static void AddLetter(int pos, char actualLetter,
        char firstCharacter, int firstPosition, char[,] banner,
        char[, ,] characters)
    {
        for (int i = 0; i < 8; i++)
        {
            int j = 0;
            int z = pos * 8;
            while (j < 8)
            {
                banner[i, z] = characters[actualLetter -
                    firstCharacter + firstPosition, i, j];
                z++;
                j++;
            }
        }
    }

    public static void Write (string phrase)
    {
        const char B = ' ';
        const char C = '#';

        char[, ,] characters = new char[55, 8, 8]
        {
        /* */{
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*!*/{
                {B, B, B, C, C, C, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /***/{
                {B, B, B, B, B, B, B, B},
                {B, B, C, B, B, B, C, B},
                {B, B, B, C, B, C, B, B},
                {B, C, C, C, C, C, C, C},
                {B, B, B, C, B, C, B, B},
                {B, B, C, B, B, B, C, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*+*/{
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*,*/{
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, C, B, B, B, B}
            },
        /*.*/{
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*-*/{
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*/*/{
                {B, B, B, B, B, B, B, C},
                {B, B, B, B, B, B, C, B},
                {B, B, B, B, B, C, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, C, B, B, B, B},
                {B, B, C, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*0*/{
                {B, B, B, C, C, C, B, B},
                {B, B, C, B, B, B, C, B},
                {B, C, B, B, B, C, B, C},
                {B, C, B, B, C, B, B, C},
                {B, C, B, C, B, B, B, C},
                {B, B, C, B, B, B, C, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*1*/{
                {B, B, B, B, C, B, B, B},
                {B, B, B, C, C, B, B, B},
                {B, B, C, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*2*/{
                {B, B, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, C},
                {B, B, B, B, B, B, B, C},
                {B, B, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, C, C, C, C, C, C},
                {B, B, B, B, B, B, B, B}
            },
        /*3*/{
                {B, B, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, C},
                {B, B, B, B, B, B, B, C},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, C},
                {B, C, B, B, B, B, B, C},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*4*/{
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, C, C, C, C, C, C},
                {B, B, B, B, B, B, C, B},
                {B, B, B, B, B, B, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*5*/{
                {B, C, C, C, C, C, C, C},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, C},
                {B, C, B, B, B, B, B, C},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*6*/{
                {B, B, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, C},
                {B, C, B, B, B, B, B, B},
                {B, C, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, C},
                {B, C, B, B, B, B, B, C},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*7*/{
                {B, C, C, C, C, C, C, C},
                {B, C, B, B, B, B, C, B},
                {B, B, B, B, B, C, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, C, B, B, B, B},
                {B, B, B, C, B, B, B, B},
                {B, B, B, C, B, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*8*/{
                {B, B, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, C},
                {B, C, B, B, B, B, B, C},
                {B, B, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, C},
                {B, C, B, B, B, B, B, C},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*9*/{
                {B, B, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, C},
                {B, C, B, B, B, B, B, C},
                {B, B, C, C, C, C, C, C},
                {B, B, B, B, B, B, B, C},
                {B, C, B, B, B, B, B, C},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*:*/{
                {B, B, B, B, C, B, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*;*/{
                {B, B, B, C, C, C, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, C, C, C, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, C, B, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*<*/{
                {B, B, B, B, B, C, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, C, B, B, B, B},
                {B, B, C, B, B, B, B, B},
                {B, B, B, C, B, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*=*/{
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*>*/{
                {B, B, C, B, B, B, B, B},
                {B, B, B, C, B, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, C, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, C, B, B, B, B},
                {B, B, C, B, B, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*?*/{
                {B, B, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, C},
                {B, B, B, B, B, B, B, C},
                {B, B, B, B, C, C, C, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*@*/{
                {B, B, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, C},
                {B, C, B, C, C, C, B, C},
                {B, C, B, C, C, C, B, C},
                {B, C, B, C, C, C, C, B},
                {B, C, B, B, B, B, B, B},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*A*/{
                {B, B, B, B, B, B, B, B},
                {B, B, B, C, C, B, B, B},
                {B, B, C, B, B, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, C, C, C, C, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*B*/{
                {B, B, B, B, B, B, B, B},
                {B, C, C, C, C, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, C, C, C, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, C, C, C, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*C*/{
                {B, B, B, B, B, B, B, B},
                {B, B, C, C, C, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, C, B},
                {B, B, C, C, C, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*D*/{
                {B, B, B, B, B, B, B, B},
                {B, C, C, C, C, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, C, C, C, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*E*/{
                {B, B, B, B, B, B, B, B},
                {B, C, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, B},
                {B, C, C, C, C, C, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*F*/{
                {B, B, B, B, B, B, B, B},
                {B, C, C, C, C, C, C, B},
                {B, C, B, B, B, B, B, B},
                {B, C, C, C, C, C, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*G*/{
                {B, B, B, B, B, B, B, B},
                {B, B, C, C, C, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, C, C, C, B},
                {B, C, B, B, B, B, C, B},
                {B, B, C, C, C, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*H*/{
                {B, B, B, B, B, B, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, C, C, C, C, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*I*/{
                {B, B, B, B, B, B, B, B},
                {B, C, C, C, C, C, C, C},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, C, C, C, C, C, C, C},
                {B, B, B, B, B, B, B, B}
            },
        /*J*/{
                {B, B, B, B, B, B, B, B},
                {B, B, B, B, B, B, C, B},
                {B, B, B, B, B, B, C, B},
                {B, B, B, B, B, B, C, B},
                {B, B, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, B, C, C, C, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*K*/{
                {B, B, B, B, B, B, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, C, B, B},
                {B, C, C, C, C, B, B, B},
                {B, C, B, B, C, B, B, B},
                {B, C, B, B, B, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*L*/{
                {B, B, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*M*/{
                {B, B, B, B, B, B, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, C, B, B, C, C, B},
                {B, C, B, C, C, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*N*/{
                {B, B, B, B, B, B, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, C, B, B, B, C, B},
                {B, C, B, C, B, B, C, B},
                {B, C, B, B, C, B, C, B},
                {B, C, B, B, B, C, C, B},
                {B, C, B, B, B, B, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*O*/{
                {B, B, B, B, B, B, B, B},
                {B, B, C, C, C, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, B, C, C, C, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*P*/{
                {B, B, B, B, B, B, B, B},
                {B, C, C, C, C, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, C, C, C, C, B, B},
                {B, C, B, B, B, B, B, B},
                {B, C, B, B, B, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*Q*/{
                {B, B, B, B, B, B, B, B},
                {B, B, C, C, C, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, C, B, C, B},
                {B, C, B, B, B, C, B, B},
                {B, B, C, C, C, B, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*R*/{
                {B, B, B, B, B, B, B, B},
                {B, C, C, C, C, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, C, C, C, C, B, B},
                {B, C, B, B, B, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*S*/{
                {B, B, B, B, B, B, B, B},
                {B, B, C, C, C, C, B, B},
                {B, C, B, B, B, B, B, B},
                {B, B, C, C, C, C, B, B},
                {B, B, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, B, C, C, C, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*T*/{
                {B, B, B, B, B, B, B, B},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*U*/{
                {B, B, B, B, B, B, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, B, C, C, C, C, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*V*/{
                {B, B, B, B, B, B, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, B, C, B, B, C, B, B},
                {B, B, B, C, C, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*W*/{
                {B, B, B, B, B, B, B, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, B, B, B, C, B},
                {B, C, B, C, C, B, C, B},
                {B, C, C, B, B, C, C, B},
                {B, C, B, B, B, B, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*X*/{
                {B, B, B, B, B, B, B, B},
                {B, C, B, B, B, B, C, B},
                {B, B, C, B, B, C, B, B},
                {B, B, B, C, C, B, B, B},
                {B, B, B, C, C, B, B, B},
                {B, B, C, B, B, C, B, B},
                {B, C, B, B, B, B, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*Y*/{
                {B, B, B, B, B, B, B, B},
                {B, B, C, B, B, B, C, B},
                {B, B, B, C, B, C, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, B, B, B}
            },
        /*Z*/{
                {B, B, B, B, B, B, B, B},
                {B, C, C, C, C, C, C, B},
                {B, B, B, B, B, C, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, C, B, B, B, B},
                {B, B, C, B, B, B, B, B},
                {B, C, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*[*/{
                {B, B, C, C, C, C, C, B},
                {B, B, C, B, B, B, B, B},
                {B, B, C, B, B, B, B, B},
                {B, B, C, B, B, B, B, B},
                {B, B, C, B, B, B, B, B},
                {B, B, C, B, B, B, B, B},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*\*/{
                {B, C, B, B, B, B, B, B},
                {B, B, C, B, B, B, B, B},
                {B, B, B, C, B, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, C, B, B},
                {B, B, B, B, B, B, C, B},
                {B, B, B, B, B, B, B, C},
                {B, B, B, B, B, B, B, B}
            },
        /*]*/{
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, C, B},
                {B, B, B, B, B, B, C, B},
                {B, B, B, B, B, B, C, B},
                {B, B, B, B, B, B, C, B},
                {B, B, B, B, B, B, C, B},
                {B, B, C, C, C, C, C, B},
                {B, B, B, B, B, B, B, B}
            },
        /*|*/{
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, C, B, B, B},
                {B, B, B, B, B, B, B, B}
            }
        };


        phrase = phrase.ToUpper();

        char[,] banner = new char[8, phrase.Length * 8];

        for (int i = 0; i < phrase.Length; i++)
        {
            if (phrase[i] == ' ' || phrase[i] == '!')
            {
                AddLetter(i, phrase[i], ' ', 0, banner, characters);
            }
            else if (phrase[i] >= '*' && phrase[i] <= ']')
            {
                AddLetter(i, phrase[i], '*', 2, banner, characters);
            }
            else if (phrase[i] == '|')
            {
                AddLetter(i, phrase[i], '|', 54, banner, characters);
            }
            else
            {
                AddLetter(i, '?', '?', 23, banner, characters);
            }
        }

        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < phrase.Length * 8; j++)
            {
                Console.Write(banner[i, j]);
            }
            Console.WriteLine();
        }
    }

    public static void Main()
    {
        Console.Write("What do you want to write? ");
        string phrase = Console.ReadLine();
        Console.WriteLine();

        Write(phrase);
    }
}
