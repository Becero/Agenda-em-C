#include<stdio.h>
#include<stdlib.h>
#include<string.h>
    char nome[100][100];
    int ddd[100];
    int tel[100];
    char email [100] [60];
    int cep[100];
    char rua [100] [100];
    int numero[100];
    int escolha, contUser = 0;
    char nomeAux[100];
void Cad(){
            printf("Entre com as informacoes do novo usuario: \n");
            printf("NOME: ");
            scanf(" %[^\n]", nome[contUser]);
            printf("Email: ");
            scanf(" %[^\n]", email[contUser]);
            printf("CEP: ");
            scanf("%d", &cep[contUser]);
            printf("RUA: ");
            scanf(" %[^\n]", rua[contUser]);
            printf("Numero: ");
            scanf("%d", &numero[contUser]);
            printf("DDD: ");
            scanf("%d", &ddd[contUser]);
            printf("TELEFONE: ");
            scanf("%d", &tel[contUser]);
            contUser++;
}

void Apre(){
     for (int i = 0; i < contUser;i++){
            printf("===================== USUARIO %d ======================\n", i + 1);
            printf("| NOME: %s\n", nome[i]);
            printf("| Email: %s\n", email[i]);
            printf("| CEP: %.d-%.3d\n",cep[i]/1000,cep[i]%100);
            printf("| RUA: %s Numero: %d\n", rua[i], numero[i]);
            printf("| TELEFONE: (%d) %d-%.4d\n", ddd[i], tel[i]/10000, tel[i]%10000);
            printf("======================================================\n\n");
     }
}

int main(){
       do{
        printf("======================== MENU ========================\n");
        printf("| 0 ........................................... SAIR |\n");
        printf("| 1 ...................................... ADICIONAR |\n");
        printf("| 2 ........................................ MOSTRAR |\n");
        printf("| 3 ...................................... PESQUISAR |\n");
        printf("| 4 .......................................... SOBRE |\n");
        printf("======================================================\n");
        scanf("%d", &escolha);
        system("cls");
        switch (escolha)
        {
        case 0:
            printf("Obrigado por utilizar o Sistema!\n");
            break;
        case 1:
            printf("===================== NOVO CADASTRO ====================\n");
            Cad();
            break;
        case 2:
            Apre();
            break;
        case 3:
            printf("===================== BUSCAR CADASTRO ===================\n");
            printf("Entre com o nome a ser verificado: ");
            scanf(" %[^\n]", nomeAux);
            for (int i = 0; i < contUser; i++){
                if(strcmp(nome[i], nomeAux) == 0)
                Apre();
                }
            break;
        case 4:
            printf("======================== SOBRE =======================\n");
            printf("| Este software foi desenvolvido para fins didaticos.|\n");
            printf("| AUTOR: Eu Mesmo                              |\n");
            printf("| DATA: 01/09/2022                                   |\n");
            printf("======================================================\n");
            break;
        default:
            printf("Opcao invalida!\n");
            break;
        }
    }while(escolha != 0);
    return 0;
}
