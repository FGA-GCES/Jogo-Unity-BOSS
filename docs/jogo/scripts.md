# Documentação dos Scripts - Jogo Unity BOSS

Esta documentação descreve o funcionamento de cada script C# do projeto Unity.

## Índice
- [Scripts de Movimento](#scripts-de-movimento)
- [Scripts de NPCs](#scripts-de-npcs)
- [Scripts de Interface](#scripts-de-interface)
- [Scripts de Sistema](#scripts-de-sistema)
- [Scripts de Combate](#scripts-de-combate)
- [Scripts de Inimigos](#scripts-de-inimigos)
- [Scripts de Menu](#scripts-de-menu)

---

## Scripts de Movimento

### MovePlayer.cs (PlayerMoveScript.cs)
**Localização:** `Assets/Scripts/Player/PlayerMoveScript.cs`

**Descrição:** Controla o movimento, animação e sistema de vida do jogador principal.

**Funcionalidades:**
- **Movimento:** Utiliza joystick virtual para controlar movimento 2D
- **Animação:** Gerencia estados de animação baseados na direção do movimento
- **Sistema de Combate:** Implementa ataques direcionais com cooldown
- **Sistema de Vida:** Gerencia HP do jogador (100, 66, 33, 0)
- **Resposta a Dano:** Reduz HP e atualiza animações correspondentes

**Variáveis Principais:**
- `movementJoystick`: Referência ao joystick de movimento
- `playerSpeed`: Velocidade de movimento do jogador
- `hp`: Pontos de vida atuais
- `isAttacking`: Flag para controle de estado de ataque

**Métodos Importantes:**
- `HandleMovement()`: Processa input do joystick e move o personagem
- `HandleAttack()`: Executa ataques direcionais
- `ReceiveDamage()`: Reduz HP e atualiza animações
- `UpdateAnimationState()`: Atualiza parâmetros de animação

---

## Scripts de NPCs

### NPCScript.cs
**Localização:** `Assets/Scripts/NPCScript.cs`

**Descrição:** Classe base para todos os NPCs com sistema de diálogo.

**Funcionalidades:**
- **Sistema de Diálogo:** Exibe conversas com efeito de digitação
- **Detecção de Proximidade:** Detecta quando o jogador está próximo
- **Interface de Diálogo:** Gerencia painéis, texto e fotos dos NPCs
- **Navegação de Diálogo:** Permite avançar e pular falas

**Variáveis Principais:**
- `dialogues[]`: Array com todas as falas do NPC
- `nameOfNPC`: Nome exibido no diálogo
- `photo`: Sprite da foto do NPC
- `wordSpeed`: Velocidade do efeito de digitação

**Métodos Importantes:**
- `Typing()`: Coroutine que simula digitação
- `NextLine()`: Avança para próxima linha de diálogo
- `SkipTalk()`: Acelera ou pula diálogo
- `RemoveText()`: Fecha interface de diálogo

### Boy2Script.cs
**Localização:** `Assets/Scripts/Boy2Script.cs`

**Descrição:** NPC com comportamento de patrulhamento e diálogo, herda de NPCScript.

**Funcionalidades:**
- **Patrulhamento:** Move-se aleatoriamente dentro de área definida
- **Pausa quando Jogador Próximo:** Para movimento durante conversas
- **Sistema de Direções:** Movimenta-se em 4 direções (cima, baixo, esquerda, direita)
- **Tempos Aleatórios:** Alterna entre caminhar e pausar com intervalos variados

**Variáveis Específicas:**
- `leftPatrolX, rightPatrolX, upPatrolY, bottomPatrolY`: Limites da área de patrulhamento
- `minWalkTime, maxWalkTime`: Tempo mínimo e máximo de caminhada
- `minPauseTime, maxPauseTime`: Tempo mínimo e máximo de pausa

### OldManScript.cs
**Localização:** `Assets/Scripts/OldManScript.cs`

**Descrição:** NPC que se move entre dois pontos fixos, herda de NPCScript.

**Funcionalidades:**
- **Movimento Linear:** Move-se entre ponto A e ponto B
- **Pausa nos Pontos:** Para por alguns segundos ao chegar em cada ponto
- **Parada durante Diálogo:** Interrompe movimento quando jogador interage

**Variáveis Específicas:**
- `pointA, pointB`: GameObjects que definem os pontos de movimento
- `currentPoint`: Ponto atual de destino
- `speed`: Velocidade de movimento

### OldWomanScript.cs
**Localização:** `Assets/Scripts/OldWomanScript.cs`

**Descrição:** NPC simples que herda apenas funcionalidades básicas de NPCScript.

**Funcionalidades:**
- Apenas sistema de diálogo básico sem movimento adicional

---

## Scripts de Interface

### SignScript.cs
**Localização:** `Assets/Scripts/SignScript.cs`

**Descrição:** Controla placas e sinais interativos no jogo.

**Funcionalidades:**
- **Exibição de Texto:** Mostra texto informativo quando jogador se aproxima
- **Ajuste de Fonte:** Adapta tamanho da fonte baseado no comprimento do texto
- **Toggle de Visibilidade:** Alterna exibição com tecla E

**Variáveis Principais:**
- `text`: Texto a ser exibido na placa
- `signBox`: GameObject do painel da placa
- `playerInRange`: Flag de proximidade do jogador

### FlipPage.cs
**Localização:** `Assets/Scripts/FlipPage.cs`

**Descrição:** Controla sistema de virar páginas em livros/diários.

**Funcionalidades:**
- **Navegação de Páginas:** Botões para avançar e retroceder páginas
- **Controle de Limites:** Desabilita botões nos limites do livro
- **Animações:** Triggera animações de virar página
- **Fechamento de Cena:** Permite fechar a cena do livro

**Variáveis Principais:**
- `maxIndex`: Número máximo de páginas
- `currentIndex`: Página atual
- `buttonF, buttonB`: Botões de navegação

### ExitButtonScript.cs
**Localização:** `Assets/Scripts/ExitButtonScript.cs`

**Descrição:** Script simples para botão de saída para o menu principal.

**Funcionalidades:**
- **Mudança de Cena:** Carrega cena do menu principal

---

## Scripts de Sistema

### SpawnPoints.cs
**Localização:** `Assets/Scripts/SpawnPoints.cs`

**Descrição:** Gerencia pontos de spawn do jogador entre cenas.

**Funcionalidades:**
- **Mapeamento de Posições:** Define posições de spawn para diferentes locais
- **Persistência de Estado:** Mantém posição do jogador entre cenas
- **Sistema de Áudio:** Controla música de fundo baseada na cena
- **Gerenciamento de Canvas:** Controla interface baseada no contexto

**Estruturas:**
- `cityMap`: Struct para armazenar coordenadas de spawn
- `currentPosition`: Enum para identificar localização atual

### SalvarPosic.cs
**Localização:** `Assets/Scripts/SalvarPosic.cs`

**Descrição:** Sistema de salvamento de posição do jogador.

**Funcionalidades:**
- **Salvamento Automático:** Salva posição do jogador ao mudar de cena
- **Carregamento de Posição:** Restaura posição salva ao entrar em cena
- **PlayerPrefs:** Utiliza sistema de preferências do Unity

### SceneTransition.cs (SceneChange.cs)
**Localização:** `Assets/Scripts/SceneTransition.cs`

**Descrição:** Gerencia transições suaves entre cenas.

**Funcionalidades:**
- **Interface de Confirmação:** Exibe painel perguntando se deseja mudar de cena
- **Animação de Fade:** Aplica efeito de fade out/in durante transição
- **Cancelamento:** Permite cancelar mudança de cena

### Loading.cs (Carregar.cs)
**Localização:** `Assets/Scripts/Loading.cs`

**Descrição:** Sistema de carregamento de cenas com interação do jogador.

**Funcionalidades:**
- **Interação com E:** Carrega nova cena ao pressionar tecla E
- **Salvamento Automático:** Salva posição antes de carregar nova cena
- **Interface Visual:** Exibe mensagem na tela quando possível interagir

### DiaryScript.cs
**Localização:** `Assets/Scripts/DiaryScript.cs`

**Descrição:** Controla abertura e exibição de diários no jogo.

**Funcionalidades:**
- **Carregamento Aditivo:** Carrega cena do diário sobre a cena atual
- **Gerenciamento de Diários:** Ativa apenas o diário correto baseado no nome
- **Detecção de Proximidade:** Detecta quando jogador pode abrir diário

---

## Scripts de Combate

### PlayerAttackScript.cs
**Localização:** `Assets/Scripts/PlayerAttackScript.cs`

**Descrição:** Gerencia sistema de ataque do jogador e inimigos.

**Funcionalidades:**
- **Detecção de Colisão:** Detecta quando ataque atinge alvo
- **Sistema de Dano:** Aplica dano diferenciado baseado no tipo de inimigo
- **Knockback:** Aplica força de repulsão em inimigos atingidos
- **Cooldown de Ataque:** Previne spam de ataques

**Métodos Principais:**
- `OnTriggerEnter2D()`: Detecta início de ataque
- `OnTriggerStay2D()`: Aplica força contínua
- `OnTriggerExit2D()`: Remove força ao fim do ataque

### PlayerAwareness.cs
**Localização:** `Assets/Scripts/PlayerAwareness.cs`

**Descrição:** Sistema de detecção de proximidade do jogador para inimigos.

**Funcionalidades:**
- **Detecção de Distância:** Calcula distância entre inimigo e jogador
- **Direção ao Jogador:** Fornece vetor normalizado para direção do jogador
- **Estado de Alerta:** Flag indicando se inimigo está ciente do jogador

**Propriedades:**
- `awareOfPlayer`: Booleano indicando se jogador está no alcance
- `directionToPlayer`: Vetor direção para o jogador
- `_playerAwarenessDistance`: Distância máxima de detecção

---

## Scripts de Inimigos

### EnemyMovement.cs
**Localização:** `Assets/Scripts/EnemyMovement.cs`

**Descrição:** Controla movimento e comportamento de inimigos padrão.

**Funcionalidades:**
- **Perseguição ao Jogador:** Move-se em direção ao jogador quando detectado
- **Sistema de Ataque:** Ataca quando próximo suficiente do jogador
- **Sistema de Vida:** Gerencia HP com diferentes estágios visuais
- **Animações Direcionais:** Atualiza animações baseadas na direção de movimento

**Variáveis Principais:**
- `_speed`: Velocidade de movimento
- `atkDuration`: Duração do ataque
- `distanceToAttack`: Distância mínima para atacar
- `hp`: Pontos de vida

### RedMovement.cs
**Localização:** `Assets/Scripts/RedMovement.cs`

**Descrição:** Variação do sistema de movimento para inimigo especial (RobotT2).

**Funcionalidades:**
- Similar ao EnemyMovement mas com comportamentos específicos
- Gerenciamento de objeto de ataque separado
- Sistema de vida específico para este tipo de inimigo

---

## Scripts de Menu

### MenuScripts.cs
**Localização:** `Assets/Scripts/MenuScripts.cs`

**Descrição:** Controla funcionalidades do menu principal.

**Funcionalidades:**
- **Iniciar Jogo:** Carrega primeira cena do jogo (SofiaHouse)
- **Sair do Jogo:** Fecha aplicação

### StoreScripts.cs (ShopScripts.cs)
**Localização:** `Assets/Scripts/StoreScripts.cs`

**Descrição:** Script para navegação para cena da loja.

**Funcionalidades:**
- **Carregar Loja:** Muda para cena "Store"

### BookScripts.cs
**Localização:** `Assets/Scripts/BookScripts.cs`

**Descrição:** Controla sons de livros interativos.

**Funcionalidades:**
- **Reprodução de Som:** Toca som quando livro é interagido
- **Debug de Estado:** Verifica se som está tocando

---

## Estrutura de Herança

```
MonoBehaviour (Unity)
├── NPCScript (Classe base para NPCs)
│   ├── Boy2Script (NPC com patrulhamento)
│   ├── OldManScript (NPC com movimento linear)
│   └── OldWomanScript (NPC estático)
├── MovePlayer (Movimento do jogador)
├── EnemyMovement (Movimento de inimigos)
├── RedMovement (Movimento de inimigo especial)
└── [Outros scripts independentes]
```

## Sistemas Principais

1. **Sistema de Diálogo:** Centralizado em NPCScript com herança
2. **Sistema de Movimento:** Separado entre jogador e inimigos
3. **Sistema de Combate:** Integração entre PlayerAttackScript e scripts de movimento
4. **Sistema de Cenas:** Múltiplos scripts para diferentes tipos de transição
5. **Sistema de Interface:** Scripts especializados para diferentes elementos UI

## Dependências Unity

- **UnityEngine:** Funcionalidades core do Unity
- **UnityEngine.UI:** Sistema de interface gráfica
- **UnityEngine.SceneManagement:** Gerenciamento de cenas
- **System.Collections:** Para Coroutines e estruturas de dados

## Padrões de Design Utilizados

- **Herança:** NPCScript como classe base
- **Component Pattern:** Scripts como componentes Unity
- **Observer Pattern:** Eventos de trigger para detecção
- **State Pattern:** Estados de movimento e ataque
