# Utilizando o TDD

<P>
Neste projeto foram realizados um conjunto de testes focado na classe Calculadora.
</P>

## Objetivo do teste

<p>
Objetivo é realizar os testes antes de aplicar as regras de negócio para que possamos ver os testes falharem e com base neles fazer a 
codificação da aplicação corrigindo os possíveis erros gerados durante
os testes.
</p>

## Casos de teste
<ol> 
    <li>TesteSomar</li>
    <li>TesteMultiplicar</li>
    <li>TesteDividir</li>
    <li>TesteSubtrair</li>
    <li>TestarDivisãoPorZero</li>
    <li>TestarHistórico</li>
</ol>
   
## TesteSomar
<p>
O método TesteSomar presente no arquivo de teste verifica a operação de adição na classe Calculadora e caso o esperado não seja alcançado
o teste vai falhar. 
O teste faz um comparação a partir dos valores passados e verifica se tanto o arquivo de teste quanto o método implementado na classe calculadora correspondem ao esperado.
</p>

## TesteMultiplicar

<p>
O método TesteMultiplicar testa a operação de multiplicação na classe Calculadora. Ele verifica se o resultado calculado coincide com o resultado esperado para diferentes conjuntos de valores de entrada.
</p>

## TesteDividir

O método TesteDividir examina a operação de divisão na classe Calculadora. Ele valida se o método dividir calcula corretamente o resultado para vários valores de entrada e o compara com o resultado esperado.

## TesteSubtrair
<p>
O método TesteSubtrair garante que a operação de subtração na classe Calculadora produza os resultados esperados. 
</p>

## TestarDivisãoPorZero

<p>
O caso de teste TestarDivisãoPorZero verifica se o método dividir lança corretamente uma exceção DivideByZeroException ao tentar dividir por zero.
</p>

## TestarHistórico

<p>
O método TestarHistórico valida a funcionalidade do método histórico na classe Calculadora. 
</p>