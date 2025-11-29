# GitHub Actions Setup Guide

This repository includes two GitHub Actions workflows for your template:

## Workflows

### 1. **Build and Test** (`.github/workflows/build-test.yml`)
- Runs on every push and pull request to `main` or `develop` branches
- Packs the template
- Tests template creation for .NET 8, 9, and 10
- Builds generated projects to ensure they work
- Uploads artifacts for review

### 2. **Publish to NuGet** (`.github/workflows/publish-nuget.yml`)
- Runs when you create a version tag (e.g., `v1.0.0`)
- Can also be triggered manually from GitHub UI
- Packs the template with the version from the tag
- Publishes to NuGet.org
- Creates a GitHub Release with the package

## Setup Instructions

### Step 1: Get NuGet API Key

1. Go to https://www.nuget.org
2. Sign in (create account if needed)
3. Click your username ? **API Keys**
4. Click **Create**
   - Key Name: `GitHub Actions - BlazorBootStrap.StarterTemplate`
   - Glob Pattern: `BlazorBootStrap.StarterTemplate`
   - Select Scopes: **Push** and **Push new packages and package versions**
5. Copy the generated API key

### Step 2: Add Secret to GitHub

1. Go to your GitHub repository
2. Click **Settings** ? **Secrets and variables** ? **Actions**
3. Click **New repository secret**
   - Name: `NUGET_API_KEY`
   - Value: Paste your NuGet API key
4. Click **Add secret**

### Step 3: Push to GitHub

```bash
git add .
git commit -m "Add GitHub Actions workflows"
git push origin main
```

## Usage

### Automatic Publishing (Recommended)

Create and push a version tag:

```bash
# Create a new version tag
git tag v1.0.0

# Push the tag to GitHub
git push origin v1.0.0
```

The workflow will automatically:
- Build the template
- Publish to NuGet.org
- Create a GitHub release

### Manual Publishing

1. Go to your repository on GitHub
2. Click **Actions** tab
3. Select **Publish Template to NuGet** workflow
4. Click **Run workflow**
5. Enter the version number
6. Click **Run workflow**

## Versioning

Follow semantic versioning (MAJOR.MINOR.PATCH):
- **MAJOR**: Breaking changes
- **MINOR**: New features (backwards compatible)
- **PATCH**: Bug fixes

Examples:
```bash
git tag v1.0.0  # Initial release
git tag v1.0.1  # Bug fix
git tag v1.1.0  # New feature
git tag v2.0.0  # Breaking change
```

## Workflow Status

You can see workflow runs in the **Actions** tab of your repository.

## Troubleshooting

### Publishing fails
- Verify `NUGET_API_KEY` secret is set correctly
- Check that the package ID doesn't conflict with existing packages
- Ensure version number is higher than previous releases

### Build fails
- Check that all project files are committed
- Verify `.template.config/template.json` is valid
- Review workflow logs in the Actions tab

## Next Steps

1. Set up the NuGet API key secret
2. Push your code to GitHub
3. Create your first release tag: `git tag v1.0.0 && git push origin v1.0.0`
4. Watch the magic happen in the Actions tab! ??
