# Use ask mode in VS Code

[Edit](https://vscode.dev/github/microsoft/vscode-docs/blob/main/docs/copilot/chat/chat-ask-mode.md "Edit this document in vscode.dev")

# Use ask mode in VS Code

Chat in Visual Studio Code lets you use natural language to interact with large language models (LLMs) to get help with your code. _Ask mode_ for chat is optimized for asking questions about your codebase, coding, and general technology concepts. Ask mode is particularly useful for getting a better understanding of your codebase, brainstorming ideas, and getting help with coding tasks.

## [Prerequisites](#_prerequisites)

-   Install the latest version of [Visual Studio Code](/download)
-   Access to [Copilot](/docs/copilot/setup). [Copilot Free plan](https://github.com/github-copilot/signup) and get a monthly limit of completions and chat interactions.

## [Why use ask mode?](#_why-use-ask-mode)

Ask mode is optimized for answering questions about your codebase, coding, and general technology concepts. You can use it to:

-   Ask questions about your codebase, such as "Where is the database connection string defined?" or "Explain the sort function".
-   Brainstorm ideas, such as "How can I improve the performance of my application?" or "Provide 3 different ways to implement a search feature".
-   Get help with coding tasks, such as "How do I create a new React component?" or "How do I implement the factory pattern?".

In ask mode, the response can contain code blocks, which you can [apply to your codebase](#_apply-a-code-block-from-chat). This works well for smaller edits within a single file. However, [edit mode](/docs/copilot/chat/copilot-edits) and [agent mode](/docs/copilot/chat/chat-agent-mode) are better suited for making larger changes across multiple files or for more complex coding tasks.

## [Use ask mode](#_use-ask-mode)

Follow these steps to get started with ask mode in VS Code:

1.  Open the Chat view (Ctrl+Alt+I) and select **Ask** from the chat mode selector.
    
    ![Screenshot showing the Chat view, showing the mode dropdown with "Ask" selected.](/assets/docs/copilot/chat/ask-mode/chat-mode-dropdown-ask.png)
    
    Directly open ask mode in VS Code [Stable](vscode://GitHub.Copilot-Chat/chat?mode=ask) or [Insiders](vscode-insiders://GitHub.Copilot-Chat/chat?mode=ask).
    
2.  Type your question in the chat input field and select **Send** (Enter) to submit it.
    
    Experiment with some of these example questions to get started:
    
    -   `"What is the factory design pattern?"`
    -   `"How do I use the fetch API in JavaScript?"`
    -   `"How do I create a new React component?"`
3.  Add context to your chat prompt by using **Add Context** or #-mentioning specific workspace files or predefined context items like `#codebase`.
    
    By adding context, you can get more relevant responses. For example, to ask questions that are specific to your current project, you can use the `#codebase` context item. Type `#` in the chat input field to view the list of available context items.
    
    Here are some example prompts that use context:
    
    -   `"Where is the db connecting string defined in #codebase?"`
    -   `"Which testing framework is used for #calculator.test.js?"`
    -   `"Summarize the changes in #changes"`
    
    Learn more about [adding context to your chat prompt](/docs/copilot/chat/copilot-chat-context).
    
4.  Notice that, based on your question, the response might include different types of rich content, such as code blocks, terminal commands, links, and references to symbols in your code.
    
    Learn how you can [apply code blocks](#_apply-a-code-block-from-chat) to your codebase, or run terminal commands directly in the integrated terminal.
    

## [Apply a code block from chat](#_apply-a-code-block-from-chat)

When your chat response contains code blocks, you can apply them individually to the corresponding file in your workspace. VS Code performs a smart apply and inserts the changes in the right location within the file.

To apply a code block to your codebase, hover over the code block and select the **Apply in Editor** button. VS Code tries to apply the proposed changes to your existing code.

![Screenshot of a chat code block response, highlighting the actions to apply changes.](/assets/docs/copilot/chat/ask-mode/copilot-chat-view-code-block-actions.png)

Alternatively, you can also copy the code or insert it at the current cursor position. Hover over the code block and select the corresponding action.

Depending on the language extension, code blocks in chat responses might support IntelliSense, similar to the experience in the editor.

If a code block contains a shell command, you can run it directly in the integrated terminal with the **Insert into Terminal** (Ctrl+Alt+Enter) action.

![Chat code block to list files with Insert into Terminal option visible](/assets/docs/copilot/chat/ask-mode/run-in-terminal.png)

Tip

Navigate between code blocks with the **Chat: Next Code Block** (Ctrl+Alt+PageDown) and **Chat Previous Code Block** (Ctrl+Alt+PageUp) commands.

## [Quick chat](#_quick-chat)

Use Quick Chat to ask a quick question without starting a full chat session on the side. Quick Chat is a lightweight chat experience that lets you open a Quick Pick to ask a question.

To open Quick Chat, select **Quick Chat** from the Copilot menu in the title bar, or use the Ctrl+Shift+Alt+L keyboard shortcut.

You can ask a question in Quick Chat, and if you want to keep the conversation going, promote it to a full chat session with the **Open in Chat View** button.

## [Special keywords](#_special-keywords)

In your prompt, you can use special keywords to get more relevant responses:

-   #-mentions: used to add context to your chat prompt. For example, `#codebase` to refer to the entire codebase, or `#<file | folder | symbol>` to refer to a specific file, folder, or symbol in your workspace. Type `#` in the chat input field to view the list of context items. Learn more about [adding context to your chat prompt](/docs/copilot/chat/copilot-chat-context).
    
-   @-mentions: used to reference a _chat participant_, which can help answer questions about a specific topic like interacting with a database. Type `@` in the chat input field to view the list of available participants. Choose from built-in participants like `@terminal`, or [extension-provided participants](https://marketplace.visualstudio.com/search?term=tag%3Achat-participant&target=VSCode&category=All%20categories&sortBy=Relevance).
    
-   _Slash commands_: provide a shortcut to commonly used instructions, such as `/fix` to propose a fix for a problem, or `/explain` to explain how the selected code works. Type `/` in the chat input field to view a list of available slash commands.
    

## [Related resources](#_related-resources)

-   [Learn more about using chat in VS Code](/docs/copilot/chat/copilot-chat)
-   [Add context to your chat prompt](/docs/copilot/chat/copilot-chat-context)
-   [Use edit mode to make code edits across multiple files](/docs/copilot/chat/copilot-edits)
-   [Use agent mode to start an autonomous coding session](/docs/copilot/chat/chat-agent-mode)

### Was this documentation helpful?

  
Yes , this page was helpfulNo , this page was not helpful

06/12/2025