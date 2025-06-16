メモ

This version of this article is about custom instructions and prompt files in VS Code. Click the tabs above for other environments.

GitHub Copilot can provide chat responses that are tailored to the way your team works, the tools you use, or the specifics of your project, if you provide it with enough context to do so. Instead of repeatedly adding this contextual detail to your chat questions, you can create files in your repository that automatically add this information for you.

There are two types of files you can use to provide context and instructions to GitHub Copilot Chat in VS Code:

-   **Repository custom instructions** allow you to specify repository-wide instructions and preferences, in a single file, that apply to any conversation held in the context of the repository.
-   **Prompt files** (public preview) allow you to save common prompt instructions and relevant context in Markdown files (`*.prompt.md`) that you can then reuse in your chat prompts. Prompt files are only available in VS Code.

While custom instructions help to add codebase-wide context to each AI workflow, prompt files let you add instructions to a specific chat interaction.

## [About repository custom instructions](https://docs.github.com/ja/copilot/customizing-copilot/about-customizing-github-copilot-chat-responses#about-repository-custom-instructions)

Repository custom instructions consist of a single file, `.github/copilot-instructions.md`, that you create in a repository. The instructions you add to the file should be short, self-contained statements that add context or relevant information to supplement chat questions.

Common use cases include:

-   **Test generation.** Create instructions for test generation, such as specifying the use of a certain test framework.
-   **Code review.** Specify instructions for reviewing code, such as telling a reviewer to look for a specific error in the code.
-   **Commit message generation.** Write instructions for generating commit messages, such as format or the type of information to include.

### [Example](https://docs.github.com/ja/copilot/customizing-copilot/about-customizing-github-copilot-chat-responses#example)

This example of a `.github/copilot-instructions.md` file contains three instructions that will be added to all chat questions.

```markdown
We use Bazel for managing our Java dependencies, not Maven, so when talking about Java packages, always give me instructions and code samples that use Bazel. We always write JavaScript with double quotes and tabs for indentation, so when your responses include JavaScript code, please follow those conventions. Our team uses Jira for tracking items of work.
```

## [About prompt files](https://docs.github.com/ja/copilot/customizing-copilot/about-customizing-github-copilot-chat-responses#about-prompt-files)

メモ

Prompt files are パブリック プレビュー and subject to change.

Prompt files let you build and share reusable prompt instructions with additional context. A prompt file is a Markdown file, stored in your workspace, that mimics the existing format of writing prompts in Copilot Chat (for example, `Rewrite #file:x.ts`). This allows blending natural language instructions, additional context, and even linking to other prompt files as dependencies.

Common use cases include:

-   **Code generation**. Create reusable prompts for components, tests, or migrations (for example, React forms, or API mocks).
-   **Domain expertise**. Share specialized knowledge through prompts, such as security practices, or compliance checks.
-   **Team collaboration**. Document patterns and guidelines with references to specs and documentation.
-   **Onboarding**. Create step-by-step guides for complex processes or project-specific patterns.

You can have multiple prompt files in your workspace, each of which defines a prompt for a different purpose.

### [Examples](https://docs.github.com/ja/copilot/customizing-copilot/about-customizing-github-copilot-chat-responses#examples)

The following examples demonstrate how to use prompt files.

-   `New React form.prompt.md` - contains instructions for a reusable task to generate a form using React.
    
    ```markdown
    Your goal is to generate a new React form component. Ask for the form name and fields if not provided. Requirements for the form: - Use form design system components: [design-system/Form.md](../docs/design-system/Form.md) - Use `react-hook-form` for form state management: - Always define TypeScript types for your form data - Prefer *uncontrolled* components using register - Use `defaultValues` to prevent unnecessary rerenders - Use `yup` for validation: - Create reusable validation schemas in separate files - Use TypeScript types to ensure type safety - Customize UX-friendly validation rules
    ```
    
-   `API security review.prompt.md` - contains reusable information about security practices for REST APIs, which can be used to do security reviews of REST APIs.
    
    ```markdown
    Secure REST API review: - Ensure all endpoints are protected by authentication and authorization - Validate all user inputs and sanitize data - Implement rate limiting and throttling - Implement logging and monitoring for security events …
    ```