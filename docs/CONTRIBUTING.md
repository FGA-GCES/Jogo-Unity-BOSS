# Como Contribuir  

Obrigado por seu interesse em contribuir com o projeto! Seguem as diretrizes:  

## **Antes de Começar**  
1. Certifique-se de ter:  
	- Unity instalado (versão 3.11.1).  
	- Git configurado.  
	- Microsoft Visual Studio Community 2022 instalado.

2. Leia o [Código de Conduta](./CODE_OF_CONDUCT.md).  

## **Fluxo de Trabalho**  
1. **Faça um Fork** do repositório.  

2. Sincronize seu repositório local:
   ```bash  
   git clone (link do seu fork)
   cd Jogo-Unity-BOSS
   git pull origin main
   ```
3. **Crie um Branch** descritiva:  
   ```bash  
   git checkout -b tipo/nome-da-branch 
   ```
Padrão de nomes:

	feat/: Nova funcionalidade (ex: feat/inimigo-zumbi).

	fix/: Correção de bugs (ex: fix/colisao-personagem).

	docs/: Atualização de documentação (ex: docs/contributing).

	refactor/: Melhoria de código sem mudança de comportamento.

	bug/: Correção de bugs (ex: bug/colisao-inimigo).

	task/: Tarefa ou melhoria (ex: task/atualizar-documentacao).

4. Faça commits atômicos claros:  
   ```bash  
   git add ArquivoModificado.cs
   git commit -m "Corrige bug de colisão com paredes. Fix #5"
   ```

5. Envie a branch para o GitHub:  
   ```bash  
   git push origin tipo/nome-da-branch
   ```

6. **Crie um Pull Request**:
Acesse o repositório original e clique em "New Pull Request".
	1. Selecione sua branch e clique em "Create Pull Request".
	2. Adicione uma descrição clara do que foi feito e por quê.
	3. Clique em "Create Pull Request" novamente para enviar.

Criterios de Aceitação:

	1. Passar nos testes.

	2. Seguir o [Padrão de Código](./CODE-PATTERNS.md) do projeto.

	3. Ter aprovação de pelo menos 1 mantenedor.

Reportando Bugs:

	Verifique se o bug já foi reportado na aba Issues. Caso não exista, crie uma nova issue.

Sugerindo Melhorias:
	
 	1. Verifique se a melhoria já foi sugerida na aba Issues. Caso não exista, crie uma nova issue.
	2. Descreva claramente a melhoria e por que ela é importante.
