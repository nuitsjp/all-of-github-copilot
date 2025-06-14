using FluentValidation;
using TodoListApi.DTOs;
using TodoListApi.Models;

namespace TodoListApi.Validators
{
    public class CreateTodoItemDtoValidator : AbstractValidator<CreateTodoItemDto>
    {
        public CreateTodoItemDtoValidator()
        {
            RuleFor(x => x.Title)
                .NotEmpty()
                .WithMessage("タイトルは必須です")
                .Length(1, 200)
                .WithMessage("タイトルは1文字以上200文字以下で入力してください");

            RuleFor(x => x.Description)
                .MaximumLength(1000)
                .WithMessage("説明は1000文字以下で入力してください");

            RuleFor(x => x.Priority)
                .IsInEnum()
                .WithMessage("有効な優先度を選択してください");
        }
    }

    public class UpdateTodoItemDtoValidator : AbstractValidator<UpdateTodoItemDto>
    {
        public UpdateTodoItemDtoValidator()
        {
            RuleFor(x => x.Title)
                .Length(1, 200)
                .When(x => !string.IsNullOrEmpty(x.Title))
                .WithMessage("タイトルは1文字以上200文字以下で入力してください");

            RuleFor(x => x.Description)
                .MaximumLength(1000)
                .When(x => !string.IsNullOrEmpty(x.Description))
                .WithMessage("説明は1000文字以下で入力してください");

            RuleFor(x => x.Priority)
                .IsInEnum()
                .When(x => x.Priority.HasValue)
                .WithMessage("有効な優先度を選択してください");
        }
    }
}
