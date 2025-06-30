namespace Escopo
{
    class Exemplo
    {
        //    void Metodo()
        //    {
        //        int variavel;
        //        //...
        //    }

        //    void OutroMetodo()
        //    {
        //        variavel = 42; // Isso gera um erro de compilação
        //    } 
        // O erro mostrado acima ocorreu porque a variável foi criada dentro de um método diferente da qual está sendo usada.

        int variavel;
        void Metodo()

        {
            variavel = 10; // Isso é permitido, pois a variável está no escopo da classe
        }
        void OutroMetodo()
        {
            variavel = 42; 
        }
    }

}


}
