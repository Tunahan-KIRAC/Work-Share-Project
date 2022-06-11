using API.DTOs;
using AutoMapper;
using CoreLayer.Models;

namespace API.Mapping
{
    public class MapProfile:Profile
    {
        public MapProfile()
        {
            CreateMap<Category, CategoryDto>();
            CreateMap<CategoryDto, Category>();

            CreateMap<WorkDto, Work>();
            CreateMap<Work, WorkDto>();

            CreateMap<User, UserDto>();
            CreateMap<UserDto, User>();

            CreateMap<Comment, CommentDto>();
            CreateMap<CommentDto, Comment>();


            CreateMap<Category, CategoryGetWithWorkByIdDto>();
            CreateMap<CategoryGetWithWorkByIdDto, Category>();

            CreateMap<Comment, CommentGetWithWorkById>();
            CreateMap<CommentGetWithWorkById, Comment>();

            CreateMap<Comment, CommentGetWithUserById>();
            CreateMap<CommentGetWithUserById, Comment>();
            
            CreateMap<User, UserGetWithWorkById>();
            CreateMap<UserGetWithWorkById, User>();

            CreateMap<User, UserGetWithCommentById>();
            CreateMap<UserGetWithCommentById, User>();

            CreateMap<Work, WorkGetWithUserById>();
            CreateMap<WorkGetWithUserById, Work>();

            CreateMap<Work, WorkGetWithCategoryById>();
            CreateMap<WorkGetWithCategoryById, Work>();

            CreateMap<Work, WorkGetWithCommentById>();
            CreateMap<WorkGetWithCommentById, Work>();

            CreateMap<Work, WorkGetAllWithCategory>();
            CreateMap<WorkGetAllWithCategory, Work>();

            CreateMap<User, LoginDto>();
            CreateMap<LoginDto, User>();

            CreateMap<User, RegisterDto>();
            CreateMap<RegisterDto, User>();



        }
    }
}
