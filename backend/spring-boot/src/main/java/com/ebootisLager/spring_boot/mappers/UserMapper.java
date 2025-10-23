package com.ebootis.spring_boot.mappers;

import com.ebootis.spring_boot.dtos.UserDTO;
import com.ebootis.spring_boot.models.User;
import org.springframework.stereotype.Component;

@Component
public class UserMapper implements IMapper<User, UserDTO> {

    @Override
    public UserDTO toDTO(User p_userEntity) {
//        if (p_userEntity == null) return null;
//
//        UserDTO userDTO = new UserDTO();
//        userDTO.setUsername(p_userEntity.getUsername());
//        userDTO.setPassword(p_userEntity.getPassword());
//        userDTO.setRole(p_userEntity.getRole());
//        return userDTO;
        return null;

    }

    @Override
    public User toEntity(UserDTO p_userDTO) {
//        if (p_userDTO == null) return null;
//        User user = new User();
//        user.setUsername(p_userDTO.getUsername());
//        user.setPassword(p_userDTO.getPassword());
//        user.setRole(p_userDTO.getRole());
//        return user;
        return null;
    }
}