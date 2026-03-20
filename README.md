# MauiNavigation 🚀

Este projeto é uma aplicação de demonstração desenvolvida com **.NET MAUI** focada em explorar e ensinar os diferentes tipos de navegação disponíveis na plataforma.

## 📋 Sobre o Projeto

O `MauiNavigation` serve como um guia prático para desenvolvedores que desejam entender como gerenciar o fluxo de telas em uma aplicação multiplataforma (Android, iOS, macOS, Windows). Ele abrange desde a navegação básica em pilha até o uso de modais e a passagem de dados complexos entre páginas.

## ✨ Funcionalidades Demonstradas

- **Navegação Hierárquica (Stack Navigation):**
  - Empilhar novas páginas (`PushAsync`).
  - Voltar para a página anterior (`PopAsync`).
  - Voltar diretamente para a página inicial da pilha (`PopToRootAsync`).
- **Navegação Modal:**
  - Abrir telas de forma independente da pilha principal (`PushModalAsync`).
  - Fechar modais programaticamente (`PopModalAsync`).
- **Passagem de Parâmetros e Dados:**
  - Envio de objetos complexos entre telas utilizando o `BindingContext`.
  - Uso de ViewModels (`AlunoViewModel`) para transporte de dados de formulários.
- **Estrutura de Páginas:**
  - `AlunosPage`: Formulário para entrada de dados (Nome, Email, Idade).
  - `DetalhesPage`: Exibição dos dados recebidos via Binding.
  - `PaginaInicial`, `Pagina2` e `PaginaFinal`: Fluxo para demonstrar a gestão da pilha de navegação.
  - `PaginaModal`: Exemplo de comportamento de tela modal.

## 🛠️ Tecnologias Utilizadas

- **Plataforma:** .NET 10.0 (MAUI)
- **Linguagem:** C#
- **Interface:** XAML
- **Padrão de Projeto:** MVVM (Model-View-ViewModel) básico para passagem de dados.

## 🚀 Como Executar

1. Certifique-se de ter o **Visual Studio 2022** (ou VS Code com extensões MAUI) instalado com a carga de trabalho do .NET MAUI.
2. Clone este repositório.
3. Abra a solução `MauiNavigation.slnx`.
4. Escolha o target desejado (Android Emulator, iOS Simulator, Windows Machine).
5. Compile e execute o projeto (F5).

## 📂 Estrutura de Pastas

```text
MauiNavigation/
├── Pages/             # Definição das Views (XAML e Code-behind)
├── ViewModels/        # Modelos de dados para transporte entre telas
├── Resources/         # Ícones, Fontes, Imagens e Estilos
└── AppShell.xaml      # Configuração da casca da aplicação (Shell)
```

---
Desenvolvido para fins educacionais e de estudo sobre navegação em .NET MAUI.
