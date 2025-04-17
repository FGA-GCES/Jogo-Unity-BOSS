# Como Contribuir  

Obrigado por seu interesse em contribuir com o projeto! Seguem as diretrizes:  

## **Antes de Come�ar**  
1. Certifique-se de ter:  
	- Unity instalado (vers�o 3.11.1).  
	- Git configurado.  
	- Microsoft Visual Studio Community 2022 instalado.

2. Leia o [C�digo de Conduta](./CODE_OF_CONDUCT.md).  

## **Fluxo de Trabalho**  
1. **Fa�a um Fork** do reposit�rio.  

2. Sincronize seu reposit�rio local:
   ```bash  
   git clone (link do seu fork)
   cd Jogo-Unity-BOSS
   git pull origin main
   ```
3. **Crie um Branch** descritiva:  
   ```bash  
   git checkout -b tipo/nome-da-branch 
   ```
Padr�o de nomes:

	feat/: Nova funcionalidade (ex: feat/inimigo-zumbi).

	fix/: Corre��o de bugs (ex: fix/colisao-personagem).

	docs/: Atualiza��o de documenta��o (ex: docs/contributing).

	refactor/: Melhoria de c�digo sem mudan�a de comportamento.

	bug/: Corre��o de bugs (ex: bug/colisao-inimigo).

	task/: Tarefa ou melhoria (ex: task/atualizar-documentacao).

4. Fa�a commits at�micos claros:  
   ```bash  
   git add ArquivoModificado.cs
   git commit -m "Corrige bug de colis�o com paredes. Fix #5"
   ```

5. Envie a branch para o GitHub:  
   ```bash  
   git push origin tipo/nome-da-branch
   ```

6. **Crie um Pull Request**:
Acesse o reposit�rio original e clique em "New Pull Request".
	1. Selecione sua branch e clique em "Create Pull Request".
	2. Adicione uma descri��o clara do que foi feito e por qu�.
	3. Clique em "Create Pull Request" novamente para enviar.

Criterios de Aceita��o:

	1. Passar nos testes.

	2. Seguir o [Padr�o de C�digo](./CODE-PATTERNS.md) do projeto.

	3. Ter aprova��o de pelo menos 1 mantenedor.

Reportando Bugs:

	Verifique se o bug j� foi reportado na aba Issues. Caso n�o exista, crie uma nova issue.

Sugerindo Melhorias:
	1. Verifique se a melhoria j� foi sugerida na aba Issues. Caso n�o exista, crie uma nova issue.
	2. Descreva claramente a melhoria e por que ela � importante.
