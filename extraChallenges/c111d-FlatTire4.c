// Adrián Navarro Gabino

#include <stdio.h>

int main()
{
	int cases;
	int start, prick;
	int i;

	scanf("%d", &cases);

	for(i = 0; i < cases; i++)
	{
		scanf("%d", &start);
		scanf("%d", &prick);

		prick -= start;

		if(prick == 0 || prick == 180 || prick == -180)
		{
			printf("DA IGUAL\n");
		}
		else if((prick > 0 && prick < 180) || (prick < -180 && prick > -360))
		{
			printf("ASCENDENTE\n");
		}
		else
		{
			printf("DESCENDENTE\n");
		}
	}

	return 0;
}