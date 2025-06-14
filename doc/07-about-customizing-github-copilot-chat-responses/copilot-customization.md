Chat in Visual Studio Code can give you responses and generate code that matches your coding practices and project requirements, if you give it the right context. Instead of repeatedly adding this information in every chat prompt, you can store this context in files and automatically include it in every chat request. In this article, you learn how to use custom instructions and prompt files to customize AI responses in VS Code.

There are three main ways to customize AI responses in Visual Studio Code:

-   **Custom instructions**: Define common guidelines or rules for tasks like generating code, performing code reviews, or generating commit messages. Custom instructions describe the conditions in which the AI should perform operate (_how_ a task should be done). Learn how to [define custom instructions](https://code.visualstudio.com/docs/copilot/copilot-customization#_custom-instructions).
    
    Example scenarios
    
    -   Specify coding practices, preferred technologies, or project requirements, so generated code follows your standards.
    -   Set rules for code reviews, such as checking for security vulnerabilities or performance issues.
    -   Provide instructions for generating commit messages or pull request titles and descriptions.
    
-   **Prompt files**: Define reusable prompts for common tasks like generating code or performing a code review. Prompt files are standalone prompts that you can run directly in chat. They describe the task to be performed (_what_ should be done). Optionally, you can include tasks-specific guidelines about how the task should be performed, or you can reference custom instructions in the prompt file. Learn how to [create prompt files](https://code.visualstudio.com/docs/copilot/copilot-customization#_prompt-files-experimental).
    
    Example scenarios
    
    -   Create reusable prompts for common coding tasks, such as scaffolding a new component, API route, or generating tests.
    -   Define prompts for performing code reviews, such as checking for code quality, security vulnerabilities, or performance issues.
    -   Create step-by-step guides for complex processes or project-specific patterns.
    -   Define prompts for generating implementation plans, architectural designs, or migration strategies.
    
-   **Custom chat modes**: Define how chat operates, which tools it can use, and how it interacts with the codebase. Each chat prompt is run within the boundaries of the chat mode, without having to configure tools and instructions for every request.
    
    Example scenarios
    
    -   Create a chat mode for planning, where the AI has read-only access to the codebase and can only generate implementation plans.
    -   Define a research chat mode, where the AI can reach out to external resources to explore new technologies or gather information.
    -   Create a front-end developer chat mode, where the AI can only generate and modify code related to front-end development.
    

## [Custom instructions](https://code.visualstudio.com/docs/copilot/copilot-customization#_custom-instructions)

Custom instructions enable you to describe common guidelines or rules to get responses that match your specific coding practices and tech stack. Instead of manually including this context in every chat query, custom instructions automatically incorporate this information with every chat request.

### [Types of custom instructions](https://code.visualstudio.com/docs/copilot/copilot-customization#_types-of-custom-instructions)

VS Code supports multiple ways to define custom instructions:

| Custom instructions type | Description |
| --- | --- |
| `.github/copilot-instructions.md` file | 
-   Describe code-generation instructions in Markdown.
-   All instructions are combined in a single file, stored within the workspace.
-   Instructions are automatically included in every chat request.
-   Supported across all editors and IDEs that support Copilot.
-   Use this file to define general coding practices, preferred technologies, and project requirements that apply to all code-generation tasks.

 |
| `.instructions.md` files | 

-   Describe code-generation instructions in Markdown.
-   Create one or more instructions files, stored in the workspace or your user profile.
-   Use glob patterns to automatically include instructions for all requests or for specific files.
-   Supported in VS Code.
-   Use these files if you want to have task-specific code-generation instructions, and to have more control over when to include instructions with your chat prompt.

 |
| VS Code settings | 

-   Specify instructions in VS Code user or workspace settings.
-   Define instructions in settings values or in one or more files.
-   Supported in VS Code.
-   Supports instructions for code generation, test generation, commit messages, code review, and PR titles and descriptions.
-   Use this option to define instructions for tasks other than code-generation.

 |

You can use a combination of these approaches to define custom instructions and the instructions are all included in the chat request. No particular order or priority is applied to the instructions, so make sure to avoid conflicting instructions in the files.

### [Custom instructions examples](https://code.visualstudio.com/docs/copilot/copilot-customization#_custom-instructions-examples)

The following examples demonstrates how to use custom instructions:

Example: general coding guidelines

```
<span><span>---</span></span>
<span><span>applyTo</span><span>: </span><span>"**"</span></span>
<span><span>---</span></span>
<span><span># Project general coding standards</span></span>
<span></span>
<span><span>## Naming Conventions</span></span>
<span><span>-</span><span> Use PascalCase for component names, interfaces, and type aliases</span></span>
<span><span>-</span><span> Use camelCase for variables, functions, and methods</span></span>
<span><span>-</span><span> Prefix private class members with underscore (_)</span></span>
<span><span>-</span><span> Use ALL_CAPS for constants</span></span>
<span></span>
<span><span>## Error Handling</span></span>
<span><span>-</span><span> Use try/catch blocks for async operations</span></span>
<span><span>-</span><span> Implement proper error boundaries in React components</span></span>
<span><span>-</span><span> Always log errors with contextual information</span></span>
<span></span>
```
Example: TypeScript and React coding guidelines

Notice how these instructions reference the general coding guidelines file. You can separate the instructions into multiple files to keep them organized and focused on specific topics.

```
<span><span>---</span></span>
<span><span>applyTo</span><span>: </span><span>"**/*.ts,**/*.tsx"</span></span>
<span><span>---</span></span>
<span><span># Project coding standards for TypeScript and React</span></span>
<span></span>
<span><span>Apply the [</span><span>general coding guidelines</span><span>](</span><span>./general-coding.instructions.md</span><span>) to all code.</span></span>
<span></span>
<span><span>## TypeScript Guidelines</span></span>
<span><span>-</span><span> Use TypeScript for all new code</span></span>
<span><span>-</span><span> Follow functional programming principles where possible</span></span>
<span><span>-</span><span> Use interfaces for data structures and type definitions</span></span>
<span><span>-</span><span> Prefer immutable data (const, readonly)</span></span>
<span><span>-</span><span> Use optional chaining (?.) and nullish coalescing (??) operators</span></span>
<span></span>
<span><span>## React Guidelines</span></span>
<span><span>-</span><span> Use functional components with hooks</span></span>
<span><span>-</span><span> Follow the React hooks rules (no conditional hooks)</span></span>
<span><span>-</span><span> Use React.FC type for components with children</span></span>
<span><span>-</span><span> Keep components small and focused</span></span>
<span><span>-</span><span> Use CSS modules for component styling</span></span>
<span></span>
```

### [Use a .github/copilot-instructions.md file](https://code.visualstudio.com/docs/copilot/copilot-customization#_use-a-githubcopilotinstructionsmd-file)

You can store custom instructions in your workspace or repository in a `.github/copilot-instructions.md` file and describe your coding practices, preferred technologies, and project requirements by using Markdown. These instructions only apply to the workspace where the file is located.

VS Code automatically includes the instructions from the `.github/copilot-instructions.md` file in every chat request and applies them for generating code.

To use a `.github/copilot-instructions.md` file:

1.  Set the [github.copilot.chat.codeGeneration.useInstructionFiles](vscode://settings/github.copilot.chat.codeGeneration.useInstructionFiles) setting to `true` to instruct VS Code to use the custom instructions file.
    
2.  Create a `.github/copilot-instructions.md` file at the root of your workspace. If needed, create a `.github` directory first.
    
3.  Describe your instructions by using natural language and in Markdown format.
    
    Whitespace between instructions is ignored, so the instructions can be written as a single paragraph, each on a new line, or separated by blank lines for legibility.
    

Note

GitHub Copilot in Visual Studio and GitHub.com also detect the `.github/copilot-instructions.md` file. If you have a workspace that you use in both VS Code and Visual Studio, you can use the same file to define custom instructions for both editors.

### [Use .instructions.md files](https://code.visualstudio.com/docs/copilot/copilot-customization#_use-instructionsmd-files)

You can also create one or more `.instructions.md` files to store custom instructions for specific tasks. For example, you can create instruction files for different programming languages, frameworks, or project types.

VS Code can automatically add instructions files to all chat requests, or you can specify for which files the instructions should be applied automatically. Alternatively, you can manually attach instructions files to a chat prompt.

VS Code supports two types of scopes for instruction files:

-   **Workspace instructions files**: are only available within the workspace and are stored in the `.github/instructions` folder of the workspace.
-   **User instruction files**: are available across multiple workspaces and are stored in the current [VS Code profile](https://code.visualstudio.com/docs/configure/profiles).

#### [Instructions file structure](https://code.visualstudio.com/docs/copilot/copilot-customization#_instructions-file-structure)

An instructions file is a Markdown file with the `.instructions.md` file suffix. The instructions file consists of two sections:

-   (Optional) Header with metadata (Front Matter syntax)
    
    -   `description`: A brief description of the instructions file. This description is displayed when you hover the instructions file in the Chat view.
        
    -   `applyTo`: Specify a glob pattern for files to which the instructions are automatically applied. To always include the custom instructions, use the `**` pattern.
        
        For example, the following instructions file is always applied:
        
        ```
        <span><span>---</span></span>
        <span><span>applyTo</span><span>: </span><span>"**"</span></span>
        <span><span>---</span></span>
        <span><span>Add a comment at the end of the file: 'Contains AI-generated edits.'</span></span>
        <span></span>
        ```
        
-   Body with the instruction content
    
    Specify the custom instructions in natural language by using Markdown formatting. You can use headings, lists, and code blocks to structure the instructions.
    
    You can reference other instruction files by using Markdown links. Use relative paths to reference these files, and ensure that the paths are correct based on the location of the instruction file.
    

#### [Create an instructions file](https://code.visualstudio.com/docs/copilot/copilot-customization#_create-an-instructions-file)

To create an instructions file:

1.  Run the **Chat: New Instructions File** command from the Command Palette (Ctrl+Shift+P).
    
2.  Choose the location where the instruction file should be created.
    
    User instruction files are stored in the [current profile folder](https://code.visualstudio.com/docs/configure/profiles). You can sync your user instruction files across multiple devices by using [Settings Sync](https://code.visualstudio.com/docs/configure/settings-sync). Make sure to configure the **Prompts and Instructions** setting in the **Settings Sync: Configure** command.
    
    By default, workspace instruction files are stored in the `.github/instructions` folder of your workspace. Add more instruction folders for your workspace with the [chat.instructionsFilesLocations](vscode://settings/chat.instructionsFilesLocations) setting.
    
3.  Enter a name for your instruction file.
    
4.  Author the custom instructions by using Markdown formatting.
    
    Reference additional workspace files as Markdown links (`[index](../index.ts)`), or as `#index.ts` references within the instructions file.
    

Use the **Chat: Configure Instructions** command from the Command Palette to select and edit an existing instructions file. This command opens the instruction file in the editor, where you can edit the instructions and metadata.

#### [Use an instructions file in chat](https://code.visualstudio.com/docs/copilot/copilot-customization#_use-an-instructions-file-in-chat)

To manually attach an instructions file to a chat prompt:

-   In the Chat view, select **Add Context** > **Instructions** and select the instruction file from the Quick Pick.
    
-   Run the **Chat: Attach Instructions** command from the Command Palette (Ctrl+Shift+P) and select the instruction file from the Quick Pick.
    

To automatically apply instructions files, specify the `applyTo` metadata property in the instructions file:

-   `**`: Apply the instructions for all chat requests.
-   `<glob pattern>`: Apply the instructions based on the types of files that are in the chat context.

### [Specify custom instructions in settings](https://code.visualstudio.com/docs/copilot/copilot-customization#_specify-custom-instructions-in-settings)

You can configure custom instructions in your user or workspace settings. This is useful to specify custom instructions for scenarios other than code generation. VS Code automatically applies the custom instructions from settings to the chat requests or to the specific tasks.

There are specific settings for different scenarios. The following table lists the settings for each type of custom instruction.

| Type of instruction | Setting name |
| --- | --- |
| Code generation | [github.copilot.chat.codeGeneration.instructions](vscode://settings/github.copilot.chat.codeGeneration.instructions) |
| Test generation | [github.copilot.chat.testGeneration.instructions](vscode://settings/github.copilot.chat.testGeneration.instructions) |
| Code review | [github.copilot.chat.reviewSelection.instructions](vscode://settings/github.copilot.chat.reviewSelection.instructions) |
| Commit message generation | [github.copilot.chat.commitMessageGeneration.instructions](vscode://settings/github.copilot.chat.commitMessageGeneration.instructions) |
| Pull request title and description generation | [github.copilot.chat.pullRequestDescriptionGeneration.instructions](vscode://settings/github.copilot.chat.pullRequestDescriptionGeneration.instructions) |

You can define the custom instructions as text in the settings value (`text` property) or reference an external file (`file` property) in your workspace.

The following code snippet shows how to define a set of instructions in the `settings.json` file.

```
<span><span>  "github.copilot.chat.codeGeneration.instructions"</span><span>: [</span></span>
<span><span>    {</span></span>
<span><span>      "text"</span><span>: </span><span>"Always add a comment: 'Generated by Copilot'."</span></span>
<span><span>    },</span></span>
<span><span>    {</span></span>
<span><span>      "text"</span><span>: </span><span>"In TypeScript always use underscore for private field names."</span></span>
<span><span>    },</span></span>
<span><span>    {</span></span>
<span><span>      "file"</span><span>: </span><span>"general.instructions.md"</span><span> // import instructions from file `general.instructions.md`</span></span>
<span><span>    },</span></span>
<span><span>    {</span></span>
<span><span>      "file"</span><span>: </span><span>"db.instructions.md"</span><span> // import instructions from file `db.instructions.md`</span></span>
<span><span>    }</span></span>
<span><span>  ],</span></span>
<span></span>
```

### [Tips for defining custom instructions](https://code.visualstudio.com/docs/copilot/copilot-customization#_tips-for-defining-custom-instructions)

-   Keep your instructions short and self-contained. Each instruction should be a single, simple statement. If you need to provide multiple pieces of information, use multiple instructions.
    
-   Don't refer to external resources in the instructions, such as specific coding standards.
    
-   Split instructions into multiple files. This approach is useful for organizing instructions by topic or type of task.
    
-   Make it easy to share custom instructions with your team or across projects by storing your instructions in instruction files. You can also version control the files to track changes over time.
    
-   Use the `applyTo` property in the instruction file header to automatically apply the instructions to specific files or folders.
    
-   Reference custom instructions in your prompt files to keep your prompts clean and focused, and to avoid duplicating instructions for different tasks.
    

## [Prompt files (experimental)](https://code.visualstudio.com/docs/copilot/copilot-customization#_prompt-files-experimental)

Prompt files are reusable prompts for common tasks like generating code or performing a code review. You define the prompt content in a Markdown file. A prompt file is a standalone prompt that you can run directly in chat. Optionally, you can also include guidelines about how the task should be performed.

Tip

Prompt files can take advantage of instruction files to reuse common guidelines and have task-specific instructions included in the prompt. For example, a security review prompt file can reference a custom instructions that describe general security practices, while also including specific instructions on how to report the findings of the review.

VS Code supports two types of scopes for prompt files:

-   **Workspace prompt files**: Are only available within the workspace and are stored in the `.github/prompts` folder of the workspace.
-   **User prompt files**: Are available across multiple workspaces and are stored in the current [VS Code profile](https://code.visualstudio.com/docs/configure/profiles).

### [Prompt file examples](https://code.visualstudio.com/docs/copilot/copilot-customization#_prompt-file-examples)

The following examples demonstrate how to use prompt files:

Example: generate a React form component

```
<span><span>---</span></span>
<span><span>mode</span><span>: </span><span>'agent'</span></span>
<span><span>tools</span><span>: [</span><span>'githubRepo'</span><span>, </span><span>'codebase'</span><span>]</span></span>
<span><span>description</span><span>: </span><span>'Generate a new React form component'</span></span>
<span><span>---</span></span>
<span><span>Your goal is to generate a new React form component based on the templates in #githubRepo contoso/react-templates.</span></span>
<span></span>
<span><span>Ask for the form name and fields if not provided.</span></span>
<span></span>
<span><span>Requirements for the form:</span></span>
<span><span>*</span><span> Use form design system components: [</span><span>design-system/Form.md</span><span>](</span><span>../docs/design-system/Form.md</span><span>)</span></span>
<span><span>*</span><span> Use </span><span>`react-hook-form`</span><span> for form state management:</span></span>
<span><span>*</span><span> Always define TypeScript types for your form data</span></span>
<span><span>*</span><span> Prefer </span><span>*uncontrolled*</span><span> components using register</span></span>
<span><span>*</span><span> Use </span><span>`defaultValues`</span><span> to prevent unnecessary rerenders</span></span>
<span><span>*</span><span> Use </span><span>`yup`</span><span> for validation:</span></span>
<span><span>*</span><span> Create reusable validation schemas in separate files</span></span>
<span><span>*</span><span> Use TypeScript types to ensure type safety</span></span>
<span><span>*</span><span> Customize UX-friendly validation rules</span></span>
<span></span>
```
Example: perform a security review of a REST API

```
<span><span>---</span></span>
<span><span>mode</span><span>: </span><span>'edit'</span></span>
<span><span>description</span><span>: </span><span>'Perform a REST API security review'</span></span>
<span><span>---</span></span>
<span><span>Perform a REST API security review:</span></span>
<span></span>
<span><span>*</span><span> Ensure all endpoints are protected by authentication and authorization</span></span>
<span><span>*</span><span> Validate all user inputs and sanitize data</span></span>
<span><span>*</span><span> Implement rate limiting and throttling</span></span>
<span><span>*</span><span> Implement logging and monitoring for security events</span></span>
<span></span>
```

### [Prompt file structure](https://code.visualstudio.com/docs/copilot/copilot-customization#_prompt-file-structure)

A prompt file is a Markdown file with the `.prompt.md` file suffix. It has the following two main sections:

-   (Optional) Header with metadata (Front Matter syntax)
    
    -   `mode`: The chat mode to use when running the prompt: `ask`, `edit`, or `agent` (default).
    -   `tools`: Array of tool (set) names to indicate which tools (sets) can be used in agent mode. Select **Configure Tools** to select the tools from the list of available tools in your workspace. If a given tool (set) is not available when running the prompt, it is ignored.
    -   `description`: A short description of the prompt.
-   Body with the prompt content
    
    Prompt files mimic the format of writing prompts in chat. This allows blending natural language instructions, additional context, and even linking to other prompt files as dependencies. You can use Markdown formatting to structure the prompt content, including headings, lists, and code blocks.
    

You can reference other workspace files, prompt files, or instructions files by using Markdown links. Use relative paths to reference these files, and ensure that the paths are correct based on the location of the prompt file.

Within a prompt file, you can reference variables by using the `${variableName}` syntax. You can reference the following variables:

-   Workspace variables - `${workspaceFolder}`, `${workspaceFolderBasename}`
-   Selection variables - `${selection}`, `${selectedText}`
-   File context variables - `${file}`, `${fileBasename}`, `${fileDirname}`, `${fileBasenameNoExtension}`
-   Input variables - `${input:variableName}`, `${input:variableName:placeholder}` (pass values to the prompt from the chat input field)

### [Create a workspace prompt file](https://code.visualstudio.com/docs/copilot/copilot-customization#_create-a-workspace-prompt-file)

Workspace prompt files are stored in your workspace and are only available in that workspace.

By default, prompt files are located in the `.github/prompts` directory of your workspace. You can specify additional prompt file locations with the [chat.promptFilesLocations](vscode://settings/chat.promptFilesLocations) setting.

To create a workspace prompt file:

1.  Run the **Chat: New Prompt File** command from the Command Palette (Ctrl+Shift+P).
    
2.  Choose the location where the prompt file should be created.
    
    By default, only the `.github/prompts` folder is available. Add more prompt folders for your workspace with the [chat.promptFilesLocations](vscode://settings/chat.promptFilesLocations) setting.
    
3.  Enter a name for your prompt file.
    
    Alternatively, you can directly create a `.prompt.md` file in the prompts folder of your workspace.
    
4.  Author the chat prompt by using Markdown formatting.
    
    Within a prompt file, reference additional workspace files as Markdown links (`[index](../index.ts)`), or as `#index.ts` references within the prompt file.
    
    You can also reference other `.prompt.md` files to create a hierarchy of prompts. You can also reference [instructions files](https://code.visualstudio.com/docs/copilot/copilot-customization#_custom-instructions) in the same way.
    

### [Create a user prompt file](https://code.visualstudio.com/docs/copilot/copilot-customization#_create-a-user-prompt-file)

User prompt files are stored in your [user profile](https://code.visualstudio.com/docs/configure/profiles). With user prompt files, you can share reusable prompts across multiple workspaces.

To create a user prompt file:

1.  Select the **Chat: New Prompt File** command from the Command Palette (Ctrl+Shift+P).
    
2.  Select **User Data Folder** as the location for the prompt file.
    
    If you use multiple [VS Code profiles](https://code.visualstudio.com/docs/configure/profiles), the prompt file is created in the current profile's user data folder.
    
3.  Enter a name for your prompt file.
    
4.  Author the chat prompt by using Markdown formatting.
    
    You can also reference other user prompt files or user instruction files.
    

### [Use a prompt file in chat](https://code.visualstudio.com/docs/copilot/copilot-customization#_use-a-prompt-file-in-chat)

You have multiple options to run a prompt file:

-   Run the **Chat: Run Prompt** command from the Command Palette (Ctrl+Shift+P) and select a prompt file from the Quick Pick.
    
-   In the Chat view, type `/` followed by the prompt file name in the chat input field.
    
    This option enables you to pass additional information in the chat input field. For example, `/create-react-form` or `/create-react-form: formName=MyForm`.
    
-   Open the prompt file in the editor, and press the play button in the editor title area. You can choose to run the prompt in the current chat session or open a new chat session.
    
    This option is useful for quickly testing and iterating on your prompt files.
    

### [Sync user prompt files across devices](https://code.visualstudio.com/docs/copilot/copilot-customization#_sync-user-prompt-files-across-devices)

VS Code can sync your user prompt files across multiple devices by using [Settings Sync](https://code.visualstudio.com/docs/configure/settings-sync).

To sync your user prompt files, enable Settings Sync for prompt and instruction files:

1.  Make sure you have [Settings Sync](https://code.visualstudio.com/docs/configure/settings-sync) enabled.
    
2.  Run **Settings Sync: Configure** from the Command Palette (Ctrl+Shift+P).
    
3.  Select **Prompts and Instructions** from the list of settings to sync.
    

## [Centrally manage instructions and prompt files in VS Code](https://code.visualstudio.com/docs/copilot/copilot-customization#_centrally-manage-instructions-and-prompt-files-in-vs-code)

Enable or disable instructions and prompt files in VS Code with the [chat.promptFiles](vscode://settings/chat.promptFiles) setting.

To centrally enable or disable this setting within your organization, check [Centrally Manage VS Code Settings](https://code.visualstudio.com/docs/setup/enterprise#_centrally-manage-vs-code-settings) in the enterprise documentation.

## [Settings](https://code.visualstudio.com/docs/copilot/copilot-customization#_settings)

Custom instructions settings

-   [chat.promptFiles](vscode://settings/chat.promptFiles) _(Experimental)_: enable reusable prompt and instruction files.
    
-   [github.copilot.chat.codeGeneration.useInstructionFiles](vscode://settings/github.copilot.chat.codeGeneration.useInstructionFiles): controls whether code instructions from `.github/copilot-instructions.md` are added to Copilot requests.
    
-   [chat.instructionsFilesLocations](vscode://settings/chat.instructionsFilesLocations) _(Experimental)_: a list of folders where instruction files are located. Relative paths are resolved from the root folder(s) of your workspace. Supports glob patterns for file paths.
    
    | Setting value | Description |
    | --- | --- |
    | `["/path/to/folder"]` | Enable instruction files for a specific path. Specify one or more folders where instruction files are located. Relative paths are resolved from the root folder(s) of your workspace.  
    By default, `.github/copilot-instructions` is added but disabled. |
    
-   [github.copilot.chat.codeGeneration.instructions](vscode://settings/github.copilot.chat.codeGeneration.instructions) _(Experimental)_: set of instructions that will be added to Copilot requests that generate code.
    
-   [github.copilot.chat.testGeneration.instructions](vscode://settings/github.copilot.chat.testGeneration.instructions) _(Experimental)_: set of instructions that will be added to Copilot requests that generate tests.
    
-   [github.copilot.chat.reviewSelection.instructions](vscode://settings/github.copilot.chat.reviewSelection.instructions) _(Preview)_: set of instructions that will be added to Copilot requests for reviewing the current editor selection.
    
-   [github.copilot.chat.commitMessageGeneration.instructions](vscode://settings/github.copilot.chat.commitMessageGeneration.instructions) _(Experimental)_: set of instructions that will be added to Copilot requests that generate commit messages.
    
-   [github.copilot.chat.pullRequestDescriptionGeneration.instructions](vscode://settings/github.copilot.chat.pullRequestDescriptionGeneration.instructions) _(Experimental)_: set of instructions that will be added to Copilot requests that generate pull request titles and descriptions.
    

Prompt files settings

-   [chat.promptFiles](vscode://settings/chat.promptFiles) _(Experimental)_: enable reusable prompt and instruction files.
    
-   [chat.promptFilesLocations](vscode://settings/chat.promptFilesLocations) _(Experimental)_: a list of folders where prompt files are located. Relative paths are resolved from the root folder(s) of your workspace. Supports glob patterns for file paths.
    
    | Setting value | Description |
    | --- | --- |
    | `["/path/to/folder"]` | Enable prompt files for a specific path. Specify one or more folders where prompt files are located. Relative paths are resolved from the root folder(s) of your workspace.  
    By default, `.github/prompts` is added but disabled. |
    

## [Related content](https://code.visualstudio.com/docs/copilot/copilot-customization#_related-content)

-   [Create custom chat modes](https://code.visualstudio.com/docs/copilot/chat/chat-modes)
-   [Get started with chat in VS Code](https://code.visualstudio.com/docs/copilot/chat/copilot-chat)
-   [Configure tools in chat](https://code.visualstudio.com/docs/copilot/chat/chat-agent-mode#_agent-mode-tools)

06/12/2025