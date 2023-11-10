﻿# Contributing Guidelines

Please remember to follow these contributing guidelines when committing or submitting a pull request to this repository.

## Commit Message Guidelines

Each commit message consists of a **header**, a **body** and a **footer**. The header has a special
format that includes a **type**, a **scope** and a **subject**:

```
<type>(<scope>): <subject>
<BLANK LINE>
<body>
<BLANK LINE>
<footer>
```

The **header** is mandatory and the **scope** of the header is optional.

Example — `fix: remove unused dependency Serilog.Sinks.Debug`

Any line of the commit message cannot be longer 100 characters. This allows the message to be easier to read on GitHub
as well as in various git tools.

#### Type

Must be one of the following:

* **feat**: A new feature.
* **fix**: A bug fix.
* **docs**: Documentation only changes.
* **style**: Changes that do not affect the meaning of the code (white-space, formatting, missing semi-colons, etc).
* **refactor**: A code change that neither fixes a bug nor adds a feature.
* **perf**: A code change that improves performance.
* **test**: Adding missing tests.
* **chore**: Changes to the build process or auxiliary tools and libraries such as documentation generation, or changes
             to project configuration files.

#### Scope

The scope is optional and could be anything specifying place of the commit change. For example `nsis`, `mac`, `linux`,
etc...

#### Subject

The subject contains succinct description of the change:

* use the imperative, present tense: `change` not `changed` nor `changes`,
* don't capitalize first letter,
* no dot (.) at the end.

#### Body

Just as in the **subject**, use the imperative, present tense: "change" not "changed" nor "changes".
The body should include the motivation for the change and contrast this with previous behavior.

#### Footer

The footer should contain any information about **Breaking Changes** and is also the place to reference GitHub issues
that this commit **Closes**.

**Breaking Changes** should start with the word `BREAKING CHANGE:` with a space or two newlines. The rest of the commit
message is then used for this.

## Pull Request Guidelines

Pull requests are the best way to propose changes to the Lantern codebase. We actively welcome your pull requests.

#### Forking

We require that all changes be made in a feature-branch and not in the master branch of a forked repository. This makes
it easier to submit multiple pull requests without confusion, and allows us to quickly glance at the branch name to get
an idea of what is being changed.

#### Branching

Branches should be prefixed with the type of change being made, followed by a short description of the change. For
example, a branch for a new feature adding support for the notification endpoint could be `feat/notification-endpoint`.

#### Committing

Please follow the **Commit Message Guidelines** above when writing commit messages.

#### Force Pushing

Force pushing to your own feature branch is allowed, but should be avoided if possible. Acceptable instances of force
pushing would be to squash commits in order to maintain a clean tree, or to update the branch with changes from master.