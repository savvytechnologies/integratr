## Contributing features and bug fixes

**Working on your first Pull Request?** You can learn how from this *free* series [How to Contribute to an Open Source Project on GitHub](https://egghead.io/series/how-to-contribute-to-an-open-source-project-on-github)

IntegratR is currently accepting contributions in the form of bug fixes. If you'd like to contribute a feature please add is to suggetions list first and link your pull request to it. If you've submitted a PR for a bug, please post a comment in the bug to avoid duplication of effort.

## Contributing features

Features (things that add new or improved functionality to IntegratR) may be accepted, but will need to first be approved by a IntegratR coordinator with the message "Approved" in the suggestion issue.

## Legal

You will need to complete a Contributor License Agreement (CLA). Briefly, this agreement testifies that you are granting us permission to use the submitted change according to the terms of the project's license, and that the work being submitted is under appropriate copyright.

Please submit a Contributor License Agreement (CLA) before submitting a pull request. Be sure to include your github user name along with the agreement. Once we have received the signed CLA, we'll review the request. 

## Housekeeping

Your pull request should: 

* Include a description of what your change intends to do
* Be a child commit of a reasonably recent commit in the **master** branch 
    * Requests need not be a single commit, but should be a linear sequence of commits (i.e. no merge commits in your PR)
* It is desirable, but not necessary, for the tests to pass at each commit
* Have clear commit messages 
    * e.g. "Refactor feature", "Fix issue", "Add tests for issue"
* Include adequate tests 
    * At least one test should fail in the absence of your non-test code changes. If your PR does not match this criteria, please specify why
    * Tests should include reasonable permutations of the target fix/change
    * Include baseline changes with your change
    * All changed code must have 100% code coverage
* Follow the code conventions descriped in [Coding guidelines](https://github.com/savvytechnologies/IntegratR/wiki/Coding-guidelines)
* To avoid line ending issues, set `autocrlf = input` and `whitespace = cr-at-eol` in your git configuration
