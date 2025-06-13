GitHub Copilot offers a suite of features. Copilot also offers a suite of features for administrators.

## [GitHub Copilot features](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#github-copilot-features)

### [Code completion](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#code-completion)

Autocomplete-style suggestions from Copilot in supported IDEs _(Visual Studio Code, Visual Studio, JetBrains IDEs, Azure Data Studio, Xcode, Vim/Neovim, and Eclipse)_. See [Getting code suggestions in your IDE with GitHub Copilot](https://docs.github.com/en/copilot/using-github-copilot/getting-code-suggestions-in-your-ide-with-github-copilot).

If you use VS Code, you can also use next edit suggestions, which will predict the location of the next edit you are likely to make and suggest a completion for it.

### [Copilot Chat](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#copilot-chat)

A chat interface that lets you ask coding-related questions. GitHub Copilot Chat is available on the GitHub website, in GitHub Mobile, in supported IDEs _(Visual Studio Code, Visual Studio, JetBrains IDEs, Eclipse IDE, and Xcode)_, and in Windows Terminal. Users can also use skills with Copilot Chat. See [Asking GitHub Copilot questions in GitHub](https://docs.github.com/en/copilot/using-github-copilot/asking-github-copilot-questions-in-github) and [Asking GitHub Copilot questions in your IDE](https://docs.github.com/en/copilot/using-github-copilot/asking-github-copilot-questions-in-your-ide).

### [Copilot coding agent (public preview)](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#copilot-coding-agent-public-preview)

An autonomous AI agent that can make code changes for you. You can assign a GitHub issue to Copilot and the agent will work on making the required changes, and will create a pull request for you to review. You can also ask Copilot to create a pull request from Copilot Chat. See [Coding agent](https://docs.github.com/en/copilot/using-github-copilot/coding-agent).

### [Copilot in the CLI](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#copilot-in-the-cli)

A chat-like interface in the terminal, where you can ask questions about the command line. You can ask Copilot to provide command suggestions or explanations of commands. Users can also integrate Copilot in Windows Terminal Canary. See [Using GitHub Copilot in the command line](https://docs.github.com/en/copilot/using-github-copilot/using-github-copilot-in-the-command-line).

### [GitHub Copilot code review](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#github-copilot-code-review)

AI-generated code review suggestions to help you write better code. See [Using GitHub Copilot code review](https://docs.github.com/en/copilot/using-github-copilot/code-review/using-copilot-code-review).

### [Copilot pull request summaries](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#copilot-pull-request-summaries)

AI-generated summaries of the changes that were made in a pull request, which files they impact, and what a reviewer should focus on when they conduct their review. See [Creating a pull request summary with GitHub Copilot](https://docs.github.com/en/copilot/using-github-copilot/using-github-copilot-for-pull-requests/creating-a-pull-request-summary-with-github-copilot).

### [Copilot Workspace (public preview)](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#copilot-workspace-public-preview)

A Copilot-enabled environment for refining your pull requests, validating changes, and integrating suggestions from reviewers. See [Using Copilot to help you work on a pull request](https://docs.github.com/en/copilot/using-github-copilot/using-github-copilot-for-pull-requests/using-copilot-to-help-you-work-on-a-pull-request).

### [Copilot text completion (public preview)](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#copilot-text-completion-public-preview)

AI-generated text completion to help you write pull request descriptions quickly and accurately. See [Using Copilot text completion](https://docs.github.com/en/copilot/using-github-copilot/using-copilot-text-completion).

### [GitHub Copilot Extensions](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#github-copilot-extensions)

GitHub Copilot Extensions are **a type of GitHub App that integrates the power of external tools into GitHub Copilot Chat**. Copilot Extensions can be developed by anyone, for private or public use, and can be shared with others through the GitHub Marketplace. See [About building Copilot Extensions](https://docs.github.com/en/copilot/building-copilot-extensions/about-building-copilot-extensions).

### [GitHub Models (public preview)](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#github-models-public-preview)

Bringing the power of industry leading large and small language models to users directly on GitHub. See [GitHub Models](https://docs.github.com/en/github-models).

### [Copilot Edits](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#copilot-edits)

Copilot Edits is available in Visual Studio Code, Visual Studio, and JetBrains IDEs. Use Copilot Edits to make changes across multiple files directly from a single Copilot Chat prompt. Copilot Edits has the following modes:

#### [Edit mode](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#edit-mode)

Edit mode is only available in Visual Studio Code and JetBrains IDEs.

Use edit mode when you want more granular control over the edits that Copilot proposes. In edit mode, you choose which files Copilot can make changes to, provide context to Copilot with each iteration, and decide whether or not to accept the suggested edits after each turn.

Edit mode is best suited to use cases where:

-   You want to make a quick, specific update to a defined set of files.
-   You want full control over the number of LLM requests Copilot uses.

#### [Agent mode](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#agent-mode)

Use agent mode when you have a specific task in mind and want to enable Copilot to autonomously edit your code. In agent mode, Copilot determines which files to make changes to, offers code changes and terminal commands to complete the task, and iterates to remediate issues until the original task is complete.

Agent mode is best suited to use cases where:

-   Your task is complex, and involves multiple steps, iterations, and error handling.
-   You want Copilot to determine the necessary steps to take to complete the task.
-   The task requires Copilot to integrate with external applications, such as an MCP server.

### [Copilot custom instructions](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#copilot-custom-instructions)

Enhance Copilot Chat responses by providing contextual details on your preferences, tools, and requirements. See [About customizing GitHub Copilot Chat responses](https://docs.github.com/en/copilot/customizing-copilot/about-customizing-github-copilot-chat-responses).

### [Copilot in GitHub Desktop (public preview)](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#copilot-in-github-desktop-public-preview)

Automatically generate commit messages and descriptions with Copilot in GitHub Desktop based on the changes you make to your project.

### [Copilot Spaces (public preview)](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#copilot-spaces-public-preview)

Organize and centralize relevant content—like code, docs, specs, and more—into Spaces that ground Copilot’s responses in the right context for a specific task. See [About organizing and sharing context with Copilot Spaces](https://docs.github.com/en/copilot/using-github-copilot/copilot-spaces/about-organizing-and-sharing-context-with-copilot-spaces).

### [Copilot knowledge bases _(Copilot Enterprise only)_](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#copilot-knowledge-bases-copilot-enterprise-only)

Create and manage collections of documentation to use as context for chatting with Copilot. When you ask a question in Copilot Chat in GitHub or in VS Code, you can specify a knowledge base as the context for your question. See [Managing Copilot knowledge bases](https://docs.github.com/en/copilot/customizing-copilot/managing-copilot-knowledge-bases).

## [GitHub Copilot features for administrators](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#github-copilot-features-for-administrators)

The following features are available to organization and enterprise owners with a Copilot Business or Copilot Enterprise plan.

### [Policy management](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#policy-management)

Manage policies for Copilot in your organization or enterprise. See [Managing policies for Copilot in your organization](https://docs.github.com/en/copilot/managing-copilot/managing-github-copilot-in-your-organization/setting-policies-for-copilot-in-your-organization/managing-policies-for-copilot-in-your-organization) and [Managing policies and features for Copilot in your enterprise](https://docs.github.com/en/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-policies-and-features-for-copilot-in-your-enterprise).

### [Access management](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#access-management)

Enterprise owners can specify which organizations in the enterprise can use Copilot, and organization owners can specify which organization members can use Copilot. See [Managing access to GitHub Copilot in your organization](https://docs.github.com/en/copilot/managing-copilot/managing-github-copilot-in-your-organization/managing-access-to-github-copilot-in-your-organization) and [Managing access to Copilot in your enterprise](https://docs.github.com/en/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-access-to-copilot-in-your-enterprise).

### [Usage data](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#usage-data)

Review Copilot usage data within your organization or enterprise to inform how to manage access and drive adoption of Copilot. See [Reviewing user activity data for Copilot in your organization](https://docs.github.com/en/copilot/managing-copilot/managing-github-copilot-in-your-organization/reviewing-activity-related-to-github-copilot-in-your-organization/reviewing-user-activity-data-for-copilot-in-your-organization) and [Viewing Copilot license usage in your enterprise](https://docs.github.com/en/copilot/managing-copilot/managing-copilot-for-your-enterprise/managing-access-to-copilot-in-your-enterprise/viewing-copilot-license-usage-in-your-enterprise).

### [Audit logs](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#audit-logs)

Review audit logs for Copilot in your organization to understand what actions have been taken and by which users. See [Reviewing audit logs for Copilot Business](https://docs.github.com/en/copilot/managing-copilot/managing-github-copilot-in-your-organization/reviewing-activity-related-to-github-copilot-in-your-organization/reviewing-audit-logs-for-copilot-business).

### [Exclude files](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#exclude-files)

Configure Copilot to ignore certain files. This can be useful if you have files that you don't want to be available to Copilot. See [Excluding content from GitHub Copilot](https://docs.github.com/en/copilot/managing-copilot/managing-github-copilot-in-your-organization/setting-policies-for-copilot-in-your-organization/excluding-content-from-github-copilot).

## [Next steps](https://docs.github.com/en/copilot/about-github-copilot/github-copilot-features#next-steps)

-   To learn more about the plans available for GitHub Copilot, see [Plans for GitHub Copilot](https://docs.github.com/en/copilot/about-github-copilot/subscription-plans-for-github-copilot).
-   To start using Copilot, see [Setting up GitHub Copilot](https://docs.github.com/en/copilot/setting-up-github-copilot).